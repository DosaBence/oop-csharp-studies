using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace nehezebb_fajlkezeleses_feladat_06_12
{
    class Book
    {
        public string Title;
        public int Price;
        public string Author;
        public bool IsFamous;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           string[]sorok =  File.ReadAllLines("konyvek2.txt");
            List<Book> konyvek = new List<Book>();
            int osszeg = 0;
            int db = 0;
            int db2 = 0;
            int db3 = 0;
            foreach (string sor in sorok)
            {
               
                string[] konyv = sor.Split(';');
                Book b = new Book();
                b.Title = konyv[0];
                b.Price = int.Parse(konyv[1]);
                b.Author = konyv[2];
                b.IsFamous = bool.Parse(konyv[3]);

                konyvek.Add(b);
                osszeg += b.Price;

                if (b.IsFamous)
                {
                    db++;
                }
                if(b.Price < 3000)
                {
                    db2++;
                }
                if(b.Price > int.MaxValue)
                {
                    db3++;
                }
            }

            foreach(Book bb in konyvek)
            {
                Console.WriteLine(bb.Title);
                Console.WriteLine(bb.Price);
                Console.WriteLine(bb.Author);
                Console.WriteLine(bb.IsFamous);
                Console.WriteLine();
            }
            Console.WriteLine("A könyv árai összesen: " + osszeg);
            Console.WriteLine("Híres könyv darabszáma: " + db);
            Console.WriteLine("3000 alatti könyv darabszáma: " + db2);
            Console.WriteLine();



        }
    }
}
