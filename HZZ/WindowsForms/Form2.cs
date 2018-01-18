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

         

            REST Poslovi = new REST();
            List<Job> lJobs = Poslovi.GetJobs();
            dataGridView1.DataSource = lJobs;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }
    }
}
