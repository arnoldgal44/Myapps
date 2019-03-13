using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        static void Main(string[] args)
        {
            //A létrehozott új típussal inicializálunk egy objektumot
            Excersise ex = new Excersise("Gál Arnold");

            ex.Name = "Gál Arnold";

            Console.WriteLine(ex.Name);

            //Beolvas egy karaktert a konzolról
            Console.ReadKey();

           
        }
    }
}
