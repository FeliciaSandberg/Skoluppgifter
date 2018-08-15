using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Header("SKAPAR HISSEN KALLE");
            var e1 = new Elevator("Kalle", -2, 10, 5, 2);
            Console.WriteLine("     " + e1.Report());
            Info("Signal till Kalle att åka upp en våning");
            e1.GoUp();
            Console.WriteLine("     " + e1.Report());

            Info("Signal till Kalle att åka upp en våning");
            e1.GoUp();
            Console.WriteLine("     " + e1.Report());

            Info("Signal till Kalle att åka upp en våning");
            e1.GoUp();
            Console.WriteLine("     " + e1.Report());

            // Test av Lisa (hissen är redan på lägsta nivå så kommer inte åka nånstans)

            Header("SKAPAR HISSEN LISA");
            var e2 = new Elevator("Lisa", 5, 8);
            Console.WriteLine("     " + e2.Report());
            Info("Signal till Lisa att åka ner en våning");
            e2.GoDown();
            Console.WriteLine("     " + e2.Report());

            Console.ReadKey();
        }

        private static void Info(string v)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(v);
            Console.ResetColor();
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(v);
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
