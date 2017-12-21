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

                if (kategorije[i].nPosition <= 9)
                {
                    newButton.Location = new Point(newButton.Width * i * 2 + 2, 35);
                    newButton.Size = new Size(width, height);
                    newButton.Left -= 300;
                    newButton.Text = kategorije[i].sDescription;
                    //newButton.Click+= new EventHandler();
                    this.Controls.Add(newButton);
                }
                else if (kategorije[i].nPosition <= 18)
                {
                    newButton.Location = new Point(newButton.Width * i * 2 + 2, 150);
                    newButton.Size = new Size(width, height);
                    newButton.Left -= 1500;
                    newButton.Text = kategorije[i].sDescription;
                    //newButton.Click+= new EventHandler();
                    this.Controls.Add(newButton);
                }
            }
        }
    }
}
// Pozvati XML, doci do response, spremiti ga u datoteku(.xml), ucitati ga u c# i prikazati rezultate
