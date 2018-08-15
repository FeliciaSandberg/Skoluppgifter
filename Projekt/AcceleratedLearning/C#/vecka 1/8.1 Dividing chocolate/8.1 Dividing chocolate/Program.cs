using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Dividing_chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The chocolate contains 24 pieces.");
            Console.WriteLine("How many want to share? ");
            try
            {
                decimal howMAny = decimal.Parse(Console.ReadLine());
                decimal sum = 24 / howMAny;
                Console.WriteLine($"Everyone get {sum} pieces");
            }

            catch (DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zero people can't divide a chocolate");
                Console.ResetColor();
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
