using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Lisa = new Person
            {
                FirstName = "Lisa",
                Gender = Genders.Girl,
                FavoriteSport = Sports.Tennis,
                
            };

            Console.WriteLine($"{Lisa.FirstName} is a {Lisa.Gender}");
            Console.WriteLine($"{Lisa.FirstName} like to play {Lisa.FavoriteSport}");
            Console.WriteLine($"{Lisa.FirstName} don't like to play {Sports.Rugby}");

            Console.WriteLine();
            Console.WriteLine("Here is a list of all sport enums:");

            foreach (var item in Enum.GetNames(typeof(Sports)))

            {
                Console.WriteLine($"* {item}");
            }

            Console.WriteLine( Environment.NewLine + "Enter a sport: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string inmatadSport = Console.ReadLine();
            Console.ResetColor();

            if (Enum.TryParse(inmatadSport, true, out Sports MyEnum))
            {
                Console.WriteLine("Oh, I know " + inmatadSport);
            }

            else
            {
                Console.WriteLine("Sorry, I don't know " + inmatadSport);
            }

            Console.ReadKey();
        }
    }
}
