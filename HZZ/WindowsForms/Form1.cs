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
    public partial class Form1 : Form2
    {
        public List<Button> button = new List<Button>();
        public List<Category> lCategories = new List<Category>();
        public Form1()
        {
            InitializeComponent();

            int width, height;
            width = 120;
            height = 75;
            REST Kategorija = new REST();
            List<Category> kategorije = Kategorija.GetWorkCategories();
            for(int i=0;i<kategorije.Count();i++)
            {
               
                Button newButton = new Button();
                newButton.Location = new Point(newButton.Width*i*2 + 4, 35);
              
                newButton.Size = new Size(width, height);
                newButton.Left -= 300;
              //  newButton.Click += new EventHandler();
                newButton.Text = kategorije[i].sDescription;
                this.Controls.Add(newButton);
            }

        }
    }
}
