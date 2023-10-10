using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class Chihuahua : GoldenRetriver //Klassen för Chihuahua som ärver från klassen GoldenRetriver
    {
        public bool _isCute { get; set; }
        public Chihuahua(string speed, string food, int legs, string breed, string size, bool isCute) : base(speed, food, legs, breed, size, isCute)
        {
            _isCute = isCute;

        }
        public override void SpecificProperty()
        {
            Console.WriteLine("{0}s är {1}", _breed, _isCute ? "söta" : "ej söta");
        }
        public void LongWalks()
        {
            Console.WriteLine("{0} Gillar inte att ta långa promenader", _breed);
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
        public override void IsMammal()
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
