using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace två_pandor_del_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = AskUserForNumber();
            AskUserIfComputingOrSum(number);
         
            Console.ReadKey();
        }

        private static void AskUserIfComputingOrSum(int number)
        {
            Console.WriteLine("choose between computing the sum (Y) and computing the product of 1(N)");
            string x = Console.ReadLine();
            if (x == "Y")
            {
                int sum = number + 1;
                Console.WriteLine($"Sum of {number} + 1 = {sum}");
            }
            else if (x == "N")
            {
                int sum = number * 1;
                Console.WriteLine($"Sum of {number} * 1 = {sum}");
            }

        }

        private static int AskUserForNumber()
        {
            Console.Write("Write a number: ");
            int x = int.Parse(Console.ReadLine());

            return x;
        }
    }
}
