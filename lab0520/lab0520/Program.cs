using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0520
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[15];
            //Hozzunk létre 5 elemű szöveg tárolására alkalmas tömböt.
            string[] sArray = new string[5];
            //Hozzunk létre egy int tömböt, amit feltöltünk 3 db elemmel(5,8,9)
            int[] iT = new int[] { 5, 8, 9 };
            //Hozzunk létre 2 dimenziós tömböt egész számoknak
            int[,] iT2 = new int[,] { {4,5 }, {2,3}, {6,8} };
            try
            {
                Console.WriteLine(iT2[0, 0]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Három dimenziós
            int[,,] iT4 = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } } };
            Console.WriteLine(iT4[1,1,0]);

            for (int i = 0; i < 50; i++)
            {
                if ((i%3)== 0)
            {
                Console.WriteLine(i);
            }

            }

            //Prím számok


            Console.ReadKey();
        }
    }
}
