using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class SunFlower : Plants // Skapar en ny klass SunFlower som ärver från klassen Plants
    {
        public int _lowestTemp { get; set; } // specifik property för klassen
        
        public SunFlower(string art, int lenght, string watering, string climate, int lowestTemp) : base(art, lenght, watering, climate) //Konstruktorn som ärver även från konstruktorn i klassen Plants
        {//tilldelar värdet på propertyn
            _lowestTemp = lowestTemp;
        }
        public void UseFul() //specifik metod för klassen
        {
            Console.WriteLine("{0}or producerar solrosolja och solrosfrön", _art);
        }
        public override void PlantInfo()
        {
            Console.WriteLine("Denna typ av blomma är: {0}", _art);
            Console.WriteLine("{0}or blir upp till {1}m lång", _art, _lenght);
            Console.WriteLine("{0}or {1}", _art, _watering);
            Console.WriteLine("{0}or lever bäst i {1}", _art, _climate);
            Console.WriteLine("Den lägsta temperaturen som {0}or kan leva i är {1}grader", _art, _lowestTemp);
            UseFul(); //anropar den specifika metoden
        }

    }
}
