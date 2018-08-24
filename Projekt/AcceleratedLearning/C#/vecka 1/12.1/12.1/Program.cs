using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "David Bowie","Freddie Mercury" };
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury" };


            DisplayArrayOfRockStars(rockstarsArray);
            DisplayListOfRockStars(rockstarsList);
            DisplayIenumerableOfRockStars(rockstarsList);
            DisplayIenumerableOfRockStars(rockstarsArray);
            DisplayListOfRockStarsObejct(rockstarsArray);
            DisplayListOfRockStarsObejct(rockstarsList);

            Console.ReadKey();
        }

        static void DisplayArrayOfRockStars(string[] rockstars)
        {
            Header($"Display Array:");
            foreach (var item in rockstars)
            {
                Console.WriteLine($"* {item}");
            }
        }

        static void DisplayListOfRockStars(List<string> rockstars)
        {
            rockstars.Add("Felicia");
            Header($"Display List:");
            foreach (var item in rockstars)
            {
                Console.WriteLine($"- {item}");
            }
        }

        static void DisplayIenumerableOfRockStars(IEnumerable<string> rockstars)
        {
            Header("display ienumerable:");
            
            foreach (var item in rockstars)
            {
                Console.WriteLine($"> {item}");
            }
        }

        static void DisplayListOfRockStarsObejct(IEnumerable<object> rockstars)
        {
            Header("Object:");
            foreach (var item in rockstars)
            {
                Console.WriteLine($"+ {item}");
            }
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{v.ToUpper()}\n");
            Console.ResetColor();
        }
    }
}
