using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Cirmi");
            Dog myDog = new Dog("Buksi");
            myCat.Sleep();
            myCat.Hunt();

            myCat.Sound();
            myDog.Sound();

            myCat.Born(4);
            myCat.Child();

            myDog.Sleep();
            myDog.Hunt();

           

            myDog.Born(4);
            myDog.Child();

            Console.ReadKey();
        }
    }
}
