using REST_api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form2 : Form
    {
        public List<Category> lCategories = new List<Category>();
        public Form2()
        {
            InitializeComponent();

            REST Kategorija = new REST();
            List<Category> kategorije = Kategorija.GetWorkCategories();
            dataGridView1.DataSource = lCategories;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
