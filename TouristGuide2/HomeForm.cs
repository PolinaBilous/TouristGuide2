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
    public partial class HomeForm : Form
    {
 
        public HomeForm()
        {
            InitializeComponent();
        }

        // Событие для открытия формы с добавлением и удалением путёвок.
        private void AddForm_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.Show();
            this.Hide();
        }

        // Событие для открытия формы с поиском путёвок.
        private void SearchForm_Click(object sender, EventArgs e)
        {
            SearchForm f = new SearchForm();
            f.Show();
            this.Hide();    
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
