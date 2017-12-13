using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REST_api;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public List<Button> button = new List<Button>();
        public List<Category> lCategories = new List<Category>();
        public Form1()
        {
            InitializeComponent();


            List<Button> button = new List<Button>();
            for (int i = 0; i<10; i++)
            {
                Button newButton = new Button();
                button.Add(newButton);
                this.Controls.Add(newButton);
            }

        }
    }
}
