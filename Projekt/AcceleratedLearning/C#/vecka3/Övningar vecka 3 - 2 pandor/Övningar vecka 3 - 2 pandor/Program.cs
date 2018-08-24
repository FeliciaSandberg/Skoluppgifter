using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar_vecka_3___2_pandor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();
            Sumnumbers(number);

            Console.ReadKey();
        }

        private static void Sumnumbers(int number)
        {
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"{sum}");   
        }

        private static int GetNumberFromUser()
        {
            Console.Write($"Write a number: ");
            int x = int.Parse(Console.ReadLine());

            return x;

        }
    }
}
