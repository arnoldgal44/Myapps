using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///Program: Kő papír olló játék leprogramozása
            ///Irta: Gál Arnold / 2019.03.06
            ///Adott: számítógép - véletlenszerű
            ///Játékos: billentyűzeten választ

            ///Megoldandó feladat 1:
            ///Cikklus programfutás, amíg a felhasználó szeretne játszani
            bool moreGame = true;

            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int playerScore = 0;

            Console.WriteLine("*****Kő/Papír/Olló játék*****");
            do
                {
                Console.WriteLine("Mit választasz? k/p/o");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        playerChoice = "kő";
                        break;
                    case 'p':
                        playerChoice = "papír";
                        break;
                    case 'o':
                        playerChoice = "olló";
                        break;
                        

                }

                    Console.Write("Akarsz még játszani? i/n");
                    if (Console.ReadKey(true).KeyChar == 'n')
                    {
                        moreGame = false;
                    }
                } while (moreGame) ;


            
            
        }
    }
}