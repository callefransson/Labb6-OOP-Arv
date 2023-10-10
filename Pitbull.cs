using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class Pitbull : GoldenRetriver //Skapar en ny klass för Pitbull och ärver från klassen GoldenRetriver
    {
        //Specifika egenskapen för klassen Pitbull
        public bool _isProtecting { get; set; }
        public Pitbull(string speed, string food, int legs, string breed, string size, bool isProtecting) : base(speed, food, legs, breed, size, isProtecting)
        {// Tilldelar värdet på parametern
            _isProtecting = isProtecting;
        }
        public override void SpecificProperty() //Specifika egenskapen för klassen Pitbull
        {
            Console.WriteLine("{0}s är {1} hundar ", _breed, _isProtecting ? "skyddande" : "ej skyddande"); // Skriver ut om hunden är skyddande eller inte. True skriver ut "skyddande" false skriver ut "ej skyddande"
        }
        public void PlayFul()
        {
            Console.WriteLine("{0}s älskar att leka", _breed);
        }
        public override void TameAnimals()
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
        public override void IsMammal() // Om djuret är däggdjur eller inte
        {
            bool isMammal = true;
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
