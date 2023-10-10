using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class Rose : Plants // Skapar en ny klass Rose som ärver från klassen Plants
    {
        public bool _isBeautiful { get; set; } // specifik property för klassen Rose
        public Rose(string art, int lenght, string watering, string climate, bool isBeautiful) : base(art, lenght, watering, climate) //Konstruktorn för klassen Rose och ärver även från konstruktorn i klassen Plants
        {//tilldelar värdet för propertyn
            _isBeautiful = isBeautiful;
        }

        public void IsBeautiful() //specifik metod för klassen
        {

            if (_isBeautiful) // true
            {
                Console.WriteLine("Detta är en vacker blomma");
            }
            else // false
            {
                Console.WriteLine("Detta är inte en vacker blomma");
            }
        }
        public override void PlantInfo()
        {
            Console.WriteLine("Denna typ av blomma är: {0}", _art);
            Console.WriteLine("{0}or blir ungefär {1}cm lång", _art, _lenght);
            Console.WriteLine("{0}or behöver {1}", _art, _watering);
            Console.WriteLine("{0}or lever bäst i {1}", _art, _climate);
            IsBeautiful(); //anropar metoden
        }
    }
}
