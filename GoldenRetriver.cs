using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class GoldenRetriver : Animal //Skapar en ny klass GoldenRetriver som ärver ifrån basklassen Animal
    {
        //specifika propertyn för klassen
        public bool _isHappy { get; set; }

        //Konstrukron som lagarar en ny egenskap för klassen och använder base för att hämta dem gemensamma egenskaperna 
        public GoldenRetriver(string speed, string food, int legs, string breed, string size, bool isHappy) : base(speed, food, legs, breed, size)
        {// tilldelar värdet på parametern
            _isHappy = isHappy;
        }
        public override void MakeSound()
        {
            Console.WriteLine("wofwof");
        }
        public override void SpecificProperty() //Specifika metoden för Golden Retriver
        {
            Console.WriteLine("{0} är en {1} hund", _breed, _isHappy ? "Väldigt glad" : "arg");
        }
        public override void TameAnimals() // Metod som skriver ut om djuret är tamt eller inte
        {
            Console.WriteLine("{0} är ett tamt djur", _breed);
        }
        public override void SameInfo()
        {
            Console.WriteLine("Typ av djur: {0}", _breed);
            Console.WriteLine("{0} är {1}", _breed, _speed);
            Console.WriteLine("Maten som {0} äter är {1}", _breed, _food);
            Console.WriteLine("{0} har {1} ben", _breed, _legs);
            Console.WriteLine("{0} är ett {1} djur", _breed, _size);
            SpecificProperty();
        }
        public override void IsMammal() //Metoden för om det är ett däggdjur eller inte
        {
            bool isMammal = true; //Skapar en bool variabel med namnet isMammal och tilldelar den true
            if (isMammal) // Om påståendet är sant (true) 
            {
                Console.WriteLine("{0} är ett däggdjur", _breed);
            }
            else // Om påståendet är falskt (false)
            {
                Console.WriteLine("{0} är inte ett däggdjur", _breed);
            }
        }


    }
}
