using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class Feline : Animal
    {
        public bool _isHerd { get; set; }
        public Feline(string speed, string food, int legs, string breed, string size, bool isHerd) : base(speed, food, legs, breed, size)
        {
            _isHerd = isHerd;
        }
        public override void SpecificProperty()
        {
            Console.WriteLine("{0} lever {1}", _breed, _isHerd ? "i flock" : "inte i flock");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Raaawwwrr");
        }
        public void IsDangerous()
        {
            Console.WriteLine("{0} är mycket farliga djur", _breed);
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
            bool isMammal = true;
            if (isMammal)
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
