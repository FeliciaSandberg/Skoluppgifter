using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8._3_Animals_in_a_list
{
    class Program
    {

        static void Main(string[] args)
        {
            string animals;

            while (true)
            {
                Console.Write("Enter a list of animals seperated by ','");
                Console.ForegroundColor = ConsoleColor.Green;
                animals = Console.ReadLine();
                Console.ResetColor();

                try
                {
                    var myList = CheckIfOK(animals);
                    Console.WriteLine($"There are {myList.Count} animals in the list");
                    break;
                }
                catch (ArgumentException x)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(x.Message);
                    Console.ResetColor();
                }
            }
            Console.ReadKey();
        }

        private static List<string> CheckIfOK(string animals)
        {
            
            List<string> myList = animals.Trim().Split(',').ToList();

            foreach (var animal in myList)
            {
                if (animal.Length > 10)
                    throw new ArgumentException($"Animal {animal} is too long");

                if (animal == " ")
                    throw new ArgumentException("Animal string don't contain any letters..");

                if (Regex.IsMatch(animal, @"\d"))
                    throw new ArgumentException($"Animal {animal} can't contain numbers");

                if (!Regex.IsMatch(animal, @"^[a-öA-Ö]+$"))
                    throw new ArgumentException($"Animal {animal} contains invalid letters");
            }

            return myList;
            
        }
    }
}
