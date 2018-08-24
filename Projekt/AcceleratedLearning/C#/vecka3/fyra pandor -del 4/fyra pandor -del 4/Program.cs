using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyra_pandor__del_4
{
    class Program
    {

        static void Main(string[] args)
        {
            int j = 1;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"* {j} *{Fibonacci(i)}");
                j++;
            }
            
        }

        public static decimal Fibonacci(decimal n)
        {
            decimal a = 0;
            decimal b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (decimal i = 0; i < n; i++)
            {
                decimal temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

       
    }
}
