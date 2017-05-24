using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace TouristGuide2
{
    public partial class AddForm : TotalForm
    {
        public AddForm()
        {
            InitializeComponent();
            from_box.MinDate = DateTime.Now;
        }

        // Метод для проверки заполнены ли обязательные поля.
        public static bool FildValidation(TextBox CompanyBox, TextBox CitiesBox, TextBox DurationBox, TextBox CostBox, ErrorProvider error)
        {
            if (CompanyBox.Text.Trim() == "" || CitiesBox.Text.Trim() == "" || DurationBox.Text.Trim() == "" || CostBox.Text.Trim() == "")
            {
                if (CompanyBox.Text.Trim() == "")
                {
                    error.SetError(CompanyBox, "Это поле обязательно для заполнения!");
                }
                if (CitiesBox.Text.Trim() == "")
                {
                    error.SetError(CitiesBox, "Это поле обязательно для заполнения!");
                }
                if (DurationBox.Text.Trim() == "")
                {
                    error.SetError(DurationBox, "Это поле обязательно для заполнения!");
                }
                if (CostBox.Text.Trim() == "")
                {
                    error.SetError(CostBox, "Это поле обязательно для заполнения!");
                }
                return false;
            }
            return true;
        }

        // Метод для удаления ошибок при заполнении полей.
        public static void ClearError(TextBox textBox, ErrorProvider errorProvider1)
        {
            if (textBox.Text != "")
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        // Методы для валидации TextBox.
        #region

        public static void CompanyValidate(TextBox textBox)
        {
            if (Regex.IsMatch(textBox.Text, @"^[а-яА-Я -]+$") || textBox.Text == "")
            {
                textBox.BackColor = Color.White;
            }
            else
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        public static void CitiesValidate(TextBox textBox)
        {
            if (Regex.IsMatch(textBox.Text, @"^([А-Яа-я]+ ?, ?)*[А-Яа-я]+$") || textBox.Text == "")
            {
                textBox.BackColor = Color.White;
            }
            else
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        public static void CostValidate(TextBox textBox)
        {
            if (Regex.IsMatch(textBox.Text, @"^[0-9,]+$") || textBox.Text == "")
            {
                textBox.BackColor = Color.White;
            }
            else
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        #endregion

        // Обработчик события для закрытия формы.
        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        // Обработчик события для добавления путёвки.
        private void AddTour_Click(object sender, EventArgs e)
        {
            int duration = 0;
            string dataFrom = "";
            int cost = 0;

            FildValidation(Company_box, Cities_box, Duration_box, Cost_box, errorProvider1);
            if (Company_box.BackColor != Color.LightPink && Cities_box.BackColor != Color.LightPink 
            && Countries_box.BackColor != Color.LightPink && Duration_box.BackColor != Color.LightPink 
            && Cost_box.BackColor != Color.LightPink)
            {
                if (FildValidation(Company_box, Cities_box, Duration_box, Cost_box, errorProvider1))
                {
                    string company = Company_box.Text;
                    string cities = Cities_box.Text;
                    string countries = Countries_box.Text;
                    string accommodations = Accomodations_box.Text;
                    string excursions = Excursion_box.Text;
                    string service = Service_box.Text;
                    if (Cost_box.Text.Length > 0 && Cost_box.Text.Length < 7)
                    {
                        cost = int.Parse(Cost_box.Text.Trim());
                    }
                    else if (Cost_box.Text.Length >= 7)
                    {
                        MessageBox.Show("Вы уверены, что цена поездки может включать более 6 знаков? Перепроверьте свои данные и попробуйте еще раз!");
                        return;
                    }
                    if (Duration_box.Text.Length > 0 && Duration_box.Text.Length < 4)
                    {
                        duration = int.Parse(Duration_box.Text.Trim());
                    }
                    else if (Duration_box.Text.Length >= 4)
                    {
                        MessageBox.Show("Вы уверены, что длительность поездки может включать более 3 знаков ? Перепроверьте свои данные и попробуйте еще раз!");
                        return;
                    }
                    if (from_box.Checked == true)
                    {
                        dataFrom = from_box.Text;
                    }
                    else
                    {
                        dataFrom = "";
                    }

                    Tour tour = new Tour(company, cities, countries, accommodations, excursions, service, duration, dataFrom, cost);
                    tours.AddTour(tour);
                    dataGridView1.Rows.Add(tours[tours.Count - 1].Company, tours[tours.Count - 1].Cities, tours[tours.Count - 1].Countries,
                    tours[tours.Count - 1].Accommodations, tours[tours.Count - 1].Excursions, tours[tours.Count - 1].Service, 
                    tours[tours.Count - 1].Duration, tours[tours.Count - 1].DataFrom, tours[tours.Count - 1].Cost);

                    Company_box.Text = "";
                    Cities_box.Text = "";
                    Countries_box.Text = "";
                    Accomodations_box.Text = "";
                    Excursion_box.Text = "";
                    Service_box.Text = "";
                    Cost_box.Text = "";
                    Duration_box.Text = "";
                    from_box.Text = "";
                }
            }
            else 
            {
                MessageBox.Show("Заполните места для ввода правильно, пожалуйста.");
            }
        }

        // Обработчик события для удаления путёвки.
        private void delete_Click(object sender, EventArgs e)
        {
            int numOfTours = tours.Count;

            Delete(deleteCitiesBox.Text, deleteCompanyBox.Text, tours);

            if (numOfTours == tours.Count)
            {
                MessageBox.Show("Путёвок с такими параметрами не найдено!");
            }
            ShowTours(tours);

            deleteCompanyBox.Text = "";
            deleteCitiesBox.Text = "";
        }

        // Метод для удаления путевки.
        private void Delete(string citiestext, string companytext, Base temp)
        {
            if (citiestext != "")
            {
                // Подсчет городов, введенных пользователем.
                int cities = 1;
                for (int i = 0; i < citiestext.Length; i++)
                {
                    if (citiestext[i] == ',')
                        cities++;
                }

                // Создание массива городов, введенных пользователем.
                string[] textArr; 

                if (cities == 1)
                {
                    textArr = new string[] { citiestext.Trim() };
                }
                else
                {
                    textArr = citiestext.Split(',');
                }

                //  Удаление путёвок.
                for (int i = 0; i < temp.Count; i++)
                {
                    int outFactor = 0;
                    string[] c_arr = temp[i].Cities.Split(',');

                    for (int j = 0; j < textArr.Length; j++)
                    {
                        for (int k = 0; k < c_arr.Length; k++)
                        {
                            if (textArr[j].Trim() == c_arr[k].Trim())
                            {
                                if (deleteCompanyBox.Text == "" || temp[i].Company == companytext)
                                {
                                    outFactor = 1;
                                    break;
                                }
                            }
                        }
                    }

                    if (outFactor == 1)
                    {
                        temp.Remove(temp[i]);
                        i--;
                    }
                }
            }
            else 
            {
                for (int i = 0; i < temp.Count; i++ )
                {
                    if (companytext != "" && temp[i].Company == companytext )
                    {
                        temp.Remove(temp[i]);
                        i--;
                    }
                }
            }
        }

        // Обработчик события для сохранения путёвки.
        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) { return; }

            string FileName = saveFileDialog1.FileName;

            string BaseToString = JsonConvert.SerializeObject(tours);
            System.IO.File.WriteAllText(FileName, BaseToString);

            MessageBox.Show("Файл успешно сохранен!");
        }

        // Обработчик события для редактироапния путёвки.
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                Tour CurrentTour = tours[index];
                EditTour f = new EditTour(CurrentTour, tours, index, this);
                f.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали путевку. Попробуйте снова!");
            }
        }

        // Обработчик события для открытия справки.
        private void Info_Click(object sender, EventArgs e)
        {
            AddFormInfo f = new AddFormInfo();
            f.Show();
        }

        // Обработчики событий для изменения текста в TextBox.
        #region

        private void Company_box_TextChanged(object sender, EventArgs e)
        {
            ClearError(Company_box, errorProvider1);
            CompanyValidate(Company_box);
        }

        private void Cities_box_TextChanged(object sender, EventArgs e)
        {
            ClearError(Cities_box, errorProvider1);
            CitiesValidate(Cities_box);
        }

        private void Countries_box_TextChanged(object sender, EventArgs e)
        {
            CitiesValidate(Countries_box);
        }

        private void Duration_box_TextChanged(object sender, EventArgs e)
        {
            ClearError(Duration_box, errorProvider1);
            CostValidate(Duration_box);
        }

        private void Cost_box_TextChanged(object sender, EventArgs e)
        {
            ClearError(Cost_box, errorProvider1);
            CostValidate(Cost_box);
        }

        #endregion

        // Обработчик события для нажатий кнопок на клавиатуре.
        private void AddForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                HomeForm f = new HomeForm();
                f.Show();
            }
            if (e.KeyCode == Keys.F1)
            {
                AddFormInfo f = new AddFormInfo();
                f.Show();
            }
        }

        // Обработчик события удаления конкретной путёвки. 
        private void DeleteCurrent_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                Tour CurrentTour = tours[index];
                tours.RemoveAt(index);
                ShowTours(tours);
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали путевку. Попробуйте снова!");
            }
        }
    }
}
