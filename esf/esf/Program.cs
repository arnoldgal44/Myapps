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
            string  s;
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

            v = 2;
            if (v == 2)
            {
                Console.WriteLine("A v értéke egyenlő 2vel");
            }
            else if (v == 3)
            {
                Console.WriteLine("A v értéke egyenlő 3val");
            }
            else
            {
                Console.WriteLine("V nem 2 és nem 3, hanem:" + v);
            }
            v = 5;
            switch (v)
            {
                case 0:
                    Console.WriteLine("Switch:" + v);
                    break;
                case 5:
                    Console.WriteLine("Switch:" + v);
                    break;
                default:
                    Console.WriteLine("Switch default:" + v);
                    break;
                 

            }

            s = Console.ReadLine();
            //Beolvas egy karaktert a konzolról
            Console.ReadKey();
            Console.WriteLine("Beolvasás a konzolról:" + s);

            int[] szamok = new int[5];
            string[] szovegek = new string[10];

            ///Tömb inicializálása
            int[] iNums = new int[] { 1, 2, 3, 4, 5 };

            string[] sFruit = new string[] { "alma", "körte", "banán", "narancs" };
            Console.WriteLine("iNums első eleme: {0} sFruit első eleme:{1}", iNums[0],sFruit[0]);
            Console.WriteLine("iNums első eleme:" + iNums[0] + "sFruit első eleme:" + sFruit[0]);

            ///Tipusos listák
            ///Lista elem
            
            
           
        }
    }
}
