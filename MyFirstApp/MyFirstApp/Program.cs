using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var fruits = new List<Fruit>();


            fruits.Add(new Fruit("Körte","Hungary",50));
            fruits.Add(new Fruit("Banán","Hungary",50));
            fruits.Add(new Fruit("Szőlő", "Hungary", 50));


            foreach (var item in fruits )
            {
                Console.WriteLine("Gyümölcs név: " + item.Nev + " hely: " + item.Szarmhely);
                
            }

           

            Console.ReadKey();


        }
    }
}
