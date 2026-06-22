using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fajlbeolvasas_gyakorlat_06_16
{
    class Szoveg
    {
        public string Name;
        public string Description;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az első szöveget: ");
            string elsoszoveg = Console.ReadLine();

            File.WriteAllText("Madarak.txt", elsoszoveg);

            Console.WriteLine("Kérem a második szöveget: ");
            elsoszoveg = Console.ReadLine();

            File.AppendAllText("Madarak.txt", elsoszoveg);

            Console.WriteLine("Kérem a harmadik szöveget: ");
            elsoszoveg = Console.ReadLine();
            File.AppendAllText("Madarak.txt", elsoszoveg);

            Console.WriteLine("A fájl tartalma:" +  "\n");


            string[] olvasas = File.ReadAllLines("Madarak.txt");

            for (int i = 0; i < olvasas.Length; i++)
            {
                Console.WriteLine(olvasas[i]);
            }
           
        }
    }
}
