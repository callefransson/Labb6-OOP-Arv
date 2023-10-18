using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    public abstract class Animal // Klassen för de djuren som delar samma egenskaper
    { // De olika propertys som används för alla klasserna
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
        public abstract void MakeSound(); // Den gemensamma metoden för alla klasser
        public abstract void SameInfo();
        public abstract void SpecificProperty(); //abstrakt metod för alla klassen som ärver från Animal klassen

        public virtual void TameAnimals() //Metod för att skriva ut dom tama djuren
        {
            Console.WriteLine("De tama djuren");
        }
        public virtual void WildAnimals() //Metod för att skriva ut dom vilda djuren
        {
            Console.WriteLine("De vilda djuren");
        }
        public virtual void IsMammal() //Metod om djuret är ett däggdjur eller inte
        {
            Console.WriteLine("Om djuren är däggdjur eller inte");
        }

    }
}
