using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class Animal // Klassen för de djuren som delar samma egenskaper
    { // De olika propertys som används för att lagra och hämta information
        public string _speed { get; set; }
        public string _food { get; set; }
        public int _legs { get; set; }
        public string _breed { get; set; }
        public string _size { get; set; }

        public Animal(string speed, string food, int legs, string breed, string size)  // Konstruktorn för alla gemensamma parametrar de delar
        { //Tilldelar värdern på parametrarna
            _speed = speed;
            _food = food;
            _legs = legs;
            _breed = breed;
            _size = size;
        }
        public virtual void MakeSound() // Den gemensamma metoden för alla djur
        {
            Console.WriteLine("{0} låter:", _breed);
        }
        // Virtual metod för att kunna skriva om metoden för varje klass
        public virtual void SameInfo()
        {
            Console.WriteLine("Informationen om djuren");
        }
        public virtual void SpecificProperty()
        {
            Console.WriteLine("Den unika metoden för alla klasser");
        }

        public virtual void TameAnimals()
        {
            Console.WriteLine("De tama djuren");
        }
        public virtual void WildAnimals()
        {
            Console.WriteLine("De vilda djuren");
        }
        public virtual void IsMammal()
        {
            Console.WriteLine("Om djuren är däggdjur eller inte");
        }

    }
}
