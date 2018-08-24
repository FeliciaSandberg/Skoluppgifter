using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyra_pandor___del1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetInputFromUSer();
            var x =  input.Reverse().ToArray();
            var y =  new string(x);
            CheckIfPalindrome(y, input);

            Console.ReadKey();
        }

        private static void CheckIfPalindrome(string y, string input)
        {
            if (input == y)
            {
                Console.WriteLine($"{input} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome");
            }
        }

        private static string GetInputFromUSer()
        {
            Console.WriteLine("Write a string and see if it's palidrome or not: ");
            string x = Console.ReadLine();

            return x; 

        }
    }
}
