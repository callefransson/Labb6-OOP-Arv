// Carl Fransson .NET23

using System.Collections.Specialized;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Labb6_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        { // Skapar nya instanser från klasserna och lagrar dem i de olika variabelnamnen och argumenten innanför parateserna skickas till konstruktorn
            Human human = new Human("Relativt snabb", "Pizza", 2, "Man", "lång", 25,"Systemutvecklare",45000);
            Rose rose = new Rose("Ros", 30, "stå i vatten", "Vama förhållanden", true);
            SunFlower sunFlower = new SunFlower("Solros", 3, "Behöver mycket vatten", "Varma förhållanden", 4);
            GoldenRetriver goldenRetriver = new GoldenRetriver("snabb", "hundmat", 4, "Golden Retriver", "stort", true);
            Pitbull pitbull = new Pitbull("snabb", "Hundmat", 4, "Pitbull", "stort",true);
            Chihuahua chihuahua = new Chihuahua("långsam", "hundmat", 4, "chihuahua", "litet",true);
            Fish fish = new Fish("snabb","andra fiskar",0,"Gädda","litet",true);
            Feline feline = new Feline("snabb", "andra djur", 4, "Lejon", "stort",true);

            // skriver ut all information om de olika djuren och växterna genom metoder från de olika klasserna
            Console.WriteLine("Information om blommorna:");
            Console.WriteLine();
            rose.PlantInfo();
            Console.WriteLine();
            sunFlower.PlantInfo();
            Console.WriteLine();

            Console.WriteLine("Information om Människan");
            Console.WriteLine();
            human.SameInfo();
            Console.Write("Människan låter:");
            human.MakeSound();
            Console.WriteLine();

            Console.WriteLine("Information om {0}:", goldenRetriver._breed);
            Console.WriteLine();
            goldenRetriver.SameInfo();
            Console.Write("{0} låter: ",goldenRetriver._breed);
            goldenRetriver.MakeSound();
            Console.WriteLine();

            Console.WriteLine("Information om {0}", pitbull._breed);
            Console.WriteLine();
            pitbull.SameInfo();
            pitbull.PlayFul();
            Console.Write("{0} låter: ", pitbull._breed);
            pitbull.MakeSound();
            Console.WriteLine();

            Console.WriteLine("Information om {0}:", chihuahua._breed);
            Console.WriteLine();
            chihuahua.SameInfo();
            chihuahua.LongWalks();
            Console.Write("{0} låter: ", chihuahua._breed);
            chihuahua.MakeSound();           
            Console.WriteLine();

            Console.WriteLine("Information om {0}:", fish._breed);
            Console.WriteLine();
            fish.SameInfo();
            fish.Aggresive();
            Console.Write("{0} låter: ", fish._breed);
            fish.MakeSound();
            Console.WriteLine();

            Console.WriteLine("Information om {0}:", feline._breed);
            Console.WriteLine();
            feline.SameInfo();
            feline.IsDangerous();
            Console.Write("{0} låter: ", feline._breed);
            feline.MakeSound();
            Console.WriteLine();

            //Skriver ut dom tama djuren och dom vilda djuren med hjälp av de olika metoderna
            Console.WriteLine("Tama eller vilda djur:");
            Console.WriteLine();
            goldenRetriver.TameAnimals();
            pitbull.TameAnimals();
            chihuahua.TameAnimals();
            Console.WriteLine();

            fish.WildAnimals();
            feline.WildAnimals();
            Console.WriteLine();

            //Programmet skriver ut om djuren är däggdjur eller inte med hjälp av metoden IsMammal()
            Console.WriteLine("Om djuren är däggdjur eller inte");
            Console.WriteLine();
            goldenRetriver.IsMammal();
            pitbull.IsMammal();
            chihuahua.IsMammal();
            fish.IsMammal();
            feline.IsMammal();
            Console.WriteLine();

            Console.WriteLine("Tryck på valfri tangent för att stänga programmet");
            Console.ReadKey();
        }
    }
}