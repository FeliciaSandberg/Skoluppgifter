using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7_Conditional_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            
            string classify;
            classify = (input > 20) ? "Higher than 20" : (input == 20) ? "Equal to 20" : "Lower than 20";

            Console.WriteLine(classify);

            Console.ReadKey();
        }
    }
}
