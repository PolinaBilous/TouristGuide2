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
    public partial class TotalForm : Form
    {
        protected Base tours = new Base();

        public TotalForm()
        {
            InitializeComponent();
        }

        // Метод для отображения туров в таблице.
        public void ShowTours(Base tours)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < tours.Count; i++)
            {
                dataGridView1.Rows.Add(tours[i].Company, tours[i].Cities, tours[i].Countries, tours[i].Accommodations,
                tours[i].Excursions, tours[i].Service, tours[i].Duration, tours[i].DataFrom, tours[i].Cost);
            }
        }

        // Обработчик события для открытия главной формы.
        protected void Home_Click(object sender, EventArgs e)
        {
            HomeForm f = new HomeForm();
            f.Show();
            this.Hide();
        }

        // Обработчик события для открытия базы.
        protected void OpenBase_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // Получаем выбранный файл.
                string FileName = openFileDialog1.FileName;
                // Читаем файл в строку.
                string FileText = System.IO.File.ReadAllText(FileName);
                tours = JsonConvert.DeserializeObject<Base>(FileText);
                ShowTours(tours);
            }
            catch
            {
                MessageBox.Show("Выбранный вами файл не содержит каталога путёвок. Попробуйте еще раз!");
            }
        }
    }
}
