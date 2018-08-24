using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace två_pandor___del_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"This program prints a multiplication table for numbers up to 12.");
            int number = GetInputFromUser();
            WriteTable(number);

            Console.ReadKey();
        }

        private static void WriteTable(int number)
        {
            for (int i = 0; i < 12; i++)
            {
                int sum = i * number;
                Console.WriteLine($"{i} * {number} = {sum}");
            }
        }

        private static int GetInputFromUser()
        {
            Console.Write("Choose a number:");
            int x = int.Parse(Console.ReadLine());

            return x;

        }
    }
}
