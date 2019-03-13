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
            int v = 0;
            //A létrehozott új típussal inicializálunk egy objektumot
            Excersise ex = new Excersise("Gál Arnold");

            ex.Name = "Gál Arnold";

            Console.WriteLine(ex.Name);

            ex.PrintName();

            Console.WriteLine(ex.getName());

            ///Ciklusok
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ciklus:<Változó hivatkozás I.>" + i);
                Console.WriteLine("Ciklus:<Változó hivatkozás II.> {0}", i);
            }
            v = 2;
            while (v>0)
            {
                Console.WriteLine("While ciklus");
                v--;

            }

            v = 2;
            do
            {
                Console.WriteLine("Do while ciklus");
                v--;
            } while (v > 0);
            //Beolvas egy karaktert a konzolról
            Console.ReadKey();

           
        }
    }
}
