using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_vecka_3___panda_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = GetInputFromUser();
            WriteOutName(name);

            int number = GetNumberFromUser();
            WriteOutSumOfNumbers(number);


            Console.ReadKey();
        }

        private static void WriteOutSumOfNumbers(int number)
        {
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine($"{i}");
                
            }
        }

        private static int GetNumberFromUser()
        {
            Console.Write("Write a number between 1-10: ");
            int x = int.Parse(Console.ReadLine());

            return x;

        }

        private static void WriteOutName(string name)
        {
            if (name == "Alice" || name == "Bob")
            {
                Console.WriteLine($"Hello {name}");
            }
            
        }

        private static string GetInputFromUser()
        {
            Console.Write("What is your name? ");
            string x = Console.ReadLine();

            return x;
        }
    }
}
