using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Excersise
    {
        /// <summary>
        ///  Adattagok létrehozása: public, private, protedted
        /// </summary>

        public string Name;

        //Konstruktor: Inicializálja az osztály adattagjait
        public Excersise(string aName)
        {
            Name = aName;
        }


        public void PrintName()
        {
            Console.WriteLine(Name);

        }

        public string getName()
        {
            return Name;
        }

        

        
        
    }
}
