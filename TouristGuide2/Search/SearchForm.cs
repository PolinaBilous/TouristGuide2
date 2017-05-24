using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristGuide2
{
    public partial class SearchForm : TotalForm
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        // Обработчик события для возвращения к основному каталогу после поиска.
        private void return_to_base_Click(object sender, EventArgs e)
        {
            ShowTours(tours);

            Company_box.Text = "";
            Cities_box.Text = "";
            Countries_box.Text = "";
            Min_cost_box.Text = "";
            Max_cost_box.Text = "";
            MinDurationBox.Text = "";
            MaxDurationBox.Text = "";
            from_box.Text = "";
            Accomodations_box.Text = "";
            Service_box.Text = "";
            Excursion_box.Text = "";
        }

        // Метод для поиска по городам и странам.
        private void SearchC(string text, Base temp, string criterion)
        {
            if (text.Trim() != "")
            {
                int cities = 1;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ',')
                    {
                        cities++;
                    }
                }

                bool res = false;
                int outFactor = 0;
                string[] text_arr;

                if (cities == 1)
                {
                    text_arr = new string[] { text.Trim() };
                }
                else
                {
                    text_arr = text.Split(',');
                }

                for (int i = 0; i < temp.Count; i++)
                {
                    string[] c_arr;

                    if (criterion == "Cities")
                    {
                        c_arr = temp[i].Cities.Split(',');
                    }
                    else
                    {
                        c_arr = temp[i].Countries.Split(',');
                    }

                    for (int j = 0; j < text_arr.Length; j++)
                    {
                        for (int k = 0; k < c_arr.Length; k++)
                        {
                            if (text_arr[j].Trim() == c_arr[k].Trim())
                            {
                                res = true;
                                break;
                            }
                            else if (k == c_arr.Length - 1) 
                            {
                                res = false;
                                outFactor = 1; 
                            }
                            else 
                            {
                                res = false; 
                            }
                        }
                    }

                    if (temp[i].Countries == "") 
                    {
                        res = true; 
                        outFactor = 0; 
                    }

                    if (res == false || outFactor == 1)
                    {
                        temp.Remove(temp[i]);
                        i--;
                    }
                    res = false;
                    outFactor = 0;
                }
            }
        }

        // Метод для поиска по условиям проживания и проезда, компаниям, экскурсиямб сервису принимающей стороны и дате отправления.
        private void Search(string text, Base temp, string criterion)
        {
            if (text.Trim() != "")
            {
                string x;
                for (int i = 0; i < temp.Count; i++)
                {
                    if (criterion == "Company")
                    {
                        x = temp[i].Company;
                    }
                    else if (criterion == "Excursions")
                    {
                        x = temp[i].Excursions;
                    }
                    else if (criterion == "Accomodations")
                    {
                        x = temp[i].Accommodations;
                    }
                    else if (criterion == "dataFrom")
                    {
                        x = temp[i].DataFrom.ToString();
                    }
                    else
                    {
                        x = temp[i].Service;
                    }

                    if (x != text && x != "")
                    {
                        temp.Remove(temp[i]);
                        i--;
                    }
                }
            }
        }

        // Метод для поиска по цене и длительности.
        private void SearchFromTo(string min, string max, Base temp, string criterion)
        {
            int x;

            if (min.Trim() != "" || max.Trim() != "")
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    if (criterion == "cost")
                    {
                        x = temp[i].Cost;
                    }
                    else
                    {
                        x = temp[i].Duration;
                    }

                    if (min == "")
                    {
                        if (x > Convert.ToInt32(max))
                        {
                            temp.Remove(temp[i]);
                            i--;
                        }
                    }

                    else if (max == "")
                    {
                        if (x < Convert.ToInt32(min))
                        {
                            temp.Remove(temp[i]);
                            i--;
                        }
                    }

                    else
                    {
                        if (x < Convert.ToInt32(min) || x > Convert.ToInt32(max))
                        {
                            temp.Remove(temp[i]);
                            i--;
                        }
                    }
                }
            }
        }

        // Обработчик события для поиска путёвок.
        private void SearchTour_Click(object sender, EventArgs e)
        {
            Base temp = new Base();
            foreach (Tour x in tours)
            {
                temp.Add(x);
            }

            //поиск по компаниям 
            Search(Company_box.Text, temp, "Company");

            //поиск по городам
            SearchC(Cities_box.Text, temp, "Cities");

            //поиск по странам
            SearchC(Countries_box.Text, temp, "Countries");

            //поиск по экскурсиям
            Search(Excursion_box.Text, temp, "Excursions");

            //поиск по условиям проживания
            Search(Accomodations_box.Text, temp, "Accomodations");

            //поис по сервису принимающей стороны
            Search(Service_box.Text, temp, "Service");

            //поиск по длительности
            SearchFromTo(MinDurationBox.Text, MaxDurationBox.Text, temp, "duration");

            //поиск по дате отправления
            if (from_box.Checked == true)
                Search(from_box.Text, temp, "dataFrom");

            //поиск по цене
            SearchFromTo(Min_cost_box.Text, Max_cost_box.Text, temp, "cost");

            if (temp.Count == 0)
                MessageBox.Show("К сожалению, петёвок с такими параметрами не найдено!");
            else
                ShowTours(temp);
        }

        // Обработчик события для открытия справки.
        private void Info_Click(object sender, EventArgs e)
        {
            SearchFormInfo f = new SearchFormInfo();
            f.Show();
       }

        // Обработчик события для нажатия клавиш на клавиатуре.
        private void SearchForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                HomeForm f = new HomeForm();
                f.Show();
            }
            if (e.KeyCode == Keys.F1)
            {
                SearchFormInfo f = new SearchFormInfo();
                f.Show();
            }
        }
    }
}
