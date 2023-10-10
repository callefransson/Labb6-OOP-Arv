using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class Fish : Animal //Ny klass som heter Fish som ärver från klassen Animal
    {
        public bool _gails { get; set; }
        public Fish(string speed, string food, int legs, string breed, string size, bool gails) : base(speed, food, legs, breed, size)
        {
            _gails = gails;

        }
        public override void SpecificProperty()
        {
            Console.WriteLine("Detta djur {0} ", _gails ? "har gälar" : "har inte gälar");
        }
        public override void MakeSound()
        {
            Console.WriteLine("blublublub");
        }
        public void Aggresive()
        {
            Console.WriteLine("{0} Kan vara agressiv om man fångar dem. Annars är dom rädd för människor", _breed);
        }
        public override void WildAnimals()
        {
            Console.WriteLine("{0} är ett vilt djur", _breed);
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
        public override void IsMammal()
        {
            bool isMammal = false;
            if (isMammal == true)
            {
                Console.WriteLine("{0} är ett däggdjur", _breed);
            }
            else
            {
                Console.WriteLine("{0} är inte ett däggdjur", _breed);
            }
        }
    }
}
