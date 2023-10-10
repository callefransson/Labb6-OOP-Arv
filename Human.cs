using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class Human : Animal //Skapar en ny klass Human som ärver ifrån basklassen Animal
    {
        // Egenskaperna som är specifika för klassen Human
        public int _age { get; set; }
        public string _work { get; set; }
        public int _salary { get; set; }
        //Konstuktorn med yttligare tre egenskaper som lagras i den. Använder base för att anropa basklassens konstruktor för de gemensamma parametrarna
        public Human(string speed, string food, int legs, string breed, string size, int age, string work, int salary) : base(speed, food, legs, breed, size)
        { //Tilldelar värdern på de nya parametrarna
            _age = age;
            _work = work;
            _salary = salary;
        }
        public override void SameInfo() //Override metod för att kunna skriva om metoden för de olika klasserna som har samma metodnamn
        {
            Console.WriteLine("Människan är {0}", _speed);
            Console.WriteLine("Favorit maträtten är {0}", _food);
            Console.WriteLine("Personen har {0} ben", _legs);
            Console.WriteLine("Personen är en {0}", _breed);
            Console.WriteLine("Personen är {0}", _size);
            Console.WriteLine("Personen är {0} år", _age);
            Console.WriteLine("Personen arbetar som {0}", _work);
            SpecificProperty(); // Anropar metoden för den specifika egenskapen som denna klassen har
        }
        public override void MakeSound()
        {
            Console.WriteLine("Hejhej");
        }
        public override void SpecificProperty() //Specifika metoden för människan
        {
            Console.WriteLine("Personen tjänar {0}kr/månaden", _salary);
        }

    }
}
