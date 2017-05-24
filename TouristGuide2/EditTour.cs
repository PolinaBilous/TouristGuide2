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
    public partial class EditTour : Form
    {
        public Tour CurrentTour { get; set; }
        public Base Tours { get; set; }
        public int Index { get; set; }
        public AddForm F { get; set; }

        public EditTour()
        {
            InitializeComponent();
        }

        public EditTour(Tour tour, Base tours, int index, AddForm f)
        {
            Index = index;
            this.CurrentTour = tour;
            Tours = tours;
            F = f;
            InitializeComponent();
        }

        // Обработчик события для загрузки формы.
        private void EditTour_Load(object sender, EventArgs e)
        {           
            Company_box.Text = CurrentTour.Company;
            Cities_box.Text = CurrentTour.Cities;
            Countries_box.Text = CurrentTour.Countries;
            Accomodations_box.Text = CurrentTour.Accommodations;
            Excursion_box.Text = CurrentTour.Excursions;
            Service_box.Text = CurrentTour.Service;
            Duration_box.Text = CurrentTour.Duration.ToString();
            from_box.Text = CurrentTour.DataFrom;
            Cost_box.Text = CurrentTour.Cost.ToString();
        }

        // Обработчик события для изменения путёвки в таблице (каталоге).
        private void Edit_Click(object sender, EventArgs e)
        {
            AddForm.FildValidation(this.Company_box, this.Cities_box, this.Duration_box, this.Cost_box, this.error);
            if (Company_box.BackColor != Color.LightPink && Cities_box.BackColor != Color.LightPink
            && Countries_box.BackColor != Color.LightPink && Duration_box.BackColor != Color.LightPink 
            && Cost_box.BackColor != Color.LightPink)
            {
                if (AddForm.FildValidation(this.Company_box, this.Cities_box, this.Duration_box, this.Cost_box, this.error))
                {
                    Tours[Index] = new Tour(Company_box.Text, Cities_box.Text, Countries_box.Text, Accomodations_box.Text, 
                    Excursion_box.Text, Service_box.Text,Convert.ToInt32(Duration_box.Text), from_box.Text, Convert.ToInt32(Cost_box.Text));
                    F.ShowTours(Tours);
                    this.Close();
                }
            }
            else 
            {
                MessageBox.Show("Заполните места для ввода правильно, пожалуйста.");
            }
        }

        // Оброботчик события для изменения текста в TextBox.
        #region

        private void Company_box_TextChanged(object sender, EventArgs e)
        {
            AddForm.ClearError(Company_box, error);
            AddForm.CompanyValidate(Company_box);
        }

        private void Cities_box_TextChanged(object sender, EventArgs e)
        {
            AddForm.ClearError(Cities_box, error);
            AddForm.CitiesValidate(Cities_box);
        }

        private void Duration_box_TextChanged(object sender, EventArgs e)
        {
            AddForm.ClearError(Duration_box, error);
            AddForm.CostValidate(Duration_box);
        }

        private void Cost_box_TextChanged(object sender, EventArgs e)
        {
            AddForm.ClearError(Cost_box, error);
            AddForm.CostValidate(Cost_box);
        }

        private void Countries_box_TextChanged(object sender, EventArgs e)
        {
            AddForm.CitiesValidate(Countries_box);
        }

        #endregion

        // Обработчик события для нажатий кнопок на клавиатуре.
        private void EditTour_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
