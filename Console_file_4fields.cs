using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fajlkezeles_gyakorlas_06_13
{
    internal class Program
    {
        class Kutya
        {
            public string Name;
            public int Age;
            public bool Oltas;
            public string Color;
        }
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("kiskutyak.txt");
            List<Kutya> kutyak = new List<Kutya>();
            int osszeg = 0;

            foreach (string sor in sorok)
            {
                
                string[] kutyaobj = sor.Split(';');
                Kutya kutyapeldany = new Kutya();
                kutyapeldany.Name = kutyaobj[0];
                kutyapeldany.Age = int.Parse(kutyaobj[1]);
                kutyapeldany.Oltas = bool.Parse(kutyaobj[2]);
                kutyapeldany.Color  = kutyaobj[3];
                kutyak.Add(kutyapeldany);

                osszeg += kutyapeldany.Age;

            }

            foreach (Kutya kutyaadat in kutyak)
            {
                Console.WriteLine(kutyaadat.Name);
                Console.WriteLine(kutyaadat.Age);
                Console.WriteLine(kutyaadat.Oltas);
                Console.WriteLine(kutyaadat.Color);
                Console.WriteLine();

            }
            Console.WriteLine("Az állatok össz. életkora: " + osszeg);
        }
    }
}
