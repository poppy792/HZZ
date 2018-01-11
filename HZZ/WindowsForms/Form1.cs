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

            int width, height;
            width = 120;
            height = 75;
            REST Kategorija = new REST();
            List<Category> kategorije = Kategorija.GetWorkCategories();
            for (int i = 0; i < kategorije.Count(); i++)
            {
                Button newButton = new Button();
                newButton.Location = new Point(newButton.Width * i * 2 + 2, 35);
                newButton.Size = new Size(width, height);
                newButton.Left -= 300;
                newButton.Text = kategorije[i].sDescription;
                newButton.Click += new EventHandler(b_Click);
                this.groupBox1.Controls.Add(newButton);

             /*   if (kategorije[i].nPosition <4)
                {
                    newButton.Location = new Point(newButton.Width * i * 2 + 2, 35);
                    newButton.Size = new Size(width, height);
                    newButton.Left -= 300;
                    newButton.Text = kategorije[i].sDescription;
                    newButton.Click += new EventHandler(b_Click);
                    this.groupBox1.Controls.Add(newButton);


                }
                 else if (kategorije[i].nPosition <= 13)
                {
                    newButton.Location = new Point(newButton.Width * i * 2 + 2, 150);
                    newButton.Size = new Size(width, height);
                    newButton.Left -= 1500;
                    newButton.Text = kategorije[i].sDescription;
                    newButton.Click += new EventHandler(b_Click);
                    this.Controls.Add(newButton);
                }
                   else if (kategorije[i].nPosition < 18)
                   {
                       newButton.Location = new Point(newButton.Width * i * 2 + 2, 265);
                       newButton.Size = new Size(width, height);
                       newButton.Left -= 2100;
                       newButton.Text = kategorije[i].sDescription;
                       newButton.Click+= new EventHandler(b_Click);
                       this.Controls.Add(newButton);
                   }
                 /*  else if (kategorije[i].nPosition < 30)
                   {
                       newButton.Location = new Point(newButton.Width * i * 2 + 2, 450);
                       newButton.Size = new Size(width, height);
                       newButton.Left -= 4100;
                       newButton.Text = kategorije[i].sDescription;
                       newButton.Click += new EventHandler(b_Click);
                       this.Controls.Add(newButton);
                   }
               }*/
            }
        }
        protected void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello"); //otvoriti formu i ispisati url
        }
    }
}
  



// Pozvati XML, doci do response, spremiti ga u datoteku(.xml), ucitati ga u c# i prikazati rezultate
/* https://developer.yahoo.com/dotnet/howto-xml_cs.html */
/*return Request.CreateResponse(HttpStatusCode.OK, terms);*//*--> Jel se mora praviti posebna klasa ponovno kao category ?*/
/* https://codehandbook.org/c-object-xml/ */
