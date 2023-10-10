using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    class Plants // Skapar en basklass Plants
    {
        //De olika propertys som tilldelas
        public string _art { get; set; }
        public int _lenght { get; set; }
        public string _watering { get; set; }
        public string _climate { get; set; }

        public Plants(string art, int lenght, string watering, string climate) //Konstruktorn som tar emot fyra parametrar
        {
            //Tilldelar värderna av parametrrarna
            _art = art;
            _lenght = lenght;
            _watering = watering;
            _climate = climate;
        }
        public virtual void PlantInfo()
        {
            Console.WriteLine("Information om växterna");
        }
    }
}
