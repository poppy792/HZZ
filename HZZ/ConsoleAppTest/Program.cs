using REST_api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            REST Kategorija = new REST();
            List<Category> kategorije = Kategorija.GetWorkCategories();
            for (int i = 0; i < kategorije.Count; i++)
            {
                if (kategorije[i].nPosition < 4)
                {
                    Console.WriteLine(kategorije[i].sDescription + "/n " + kategorije[i].nID);
                    Console.WriteLine("-----------------------------------");
                }
                 if (kategorije[i].nPosition < 8)
                {
                    Console.WriteLine(kategorije[i].sDescription + "/n " + kategorije[i].nID);
                    Console.WriteLine("-----------------------------------");
                }
            }
            Console.ReadLine();

        }
    }
}
