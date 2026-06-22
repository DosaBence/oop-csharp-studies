using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace minivizsga_1_06_10
{
    internal class Program
    {
        class Animal
        {
            public string Name;
            public int Age;

            public void Describe()
            {
                Console.WriteLine("Neve: " + Name);
                Console.WriteLine("Kora " + Age);
            }
            public virtual void MakeSound()
            {
                Console.WriteLine("Az állat hangja : ");
            }
           
        }
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Vau, vau!");
            }
        }
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Miau, miau!");
            }
        }
        class Bird : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Csip, csip!");
            }
        }
        
        static void Main(string[] args)
        {
            List<Animal> allat = new List<Animal>();

            Dog dog = new Dog();
            dog.Name = "Baba";
            dog.Age = 10;

            Cat cat = new Cat();
            cat.Name = "Nyulas";
            cat.Age = 3;

            Bird bird = new Bird();
            bird.Name = "Rigóm";
            bird.Age = 2;


            allat.Add(dog);
            allat.Add(cat);
            allat.Add(bird);

            foreach (Animal ab in allat)
            {
                ab.Describe();
                ab.MakeSound();
            }
        }
    }
}
