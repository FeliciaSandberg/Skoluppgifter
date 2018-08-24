using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Clean_user_input__med_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input
            String names = GetInputFromUser();
            //split input
            string[] SplittedNames = SplitNameString(names);
            //write out list
            WriteOutList(SplittedNames);
            Console.ReadKey();
        }

        private static void WriteOutList(string[] splittedNames)
        {
            foreach (var item in splittedNames)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"***SUPER-{item.ToUpper()}***");
            }
        }

        private static string[] SplitNameString(string names)
        {
            string[] SplittedNames = names.Trim().Split(',');

            return SplittedNames;
        }

        public static string GetInputFromUser()
        {
            Console.WriteLine("Enter names separated by ',' (Lasse,Jonas,Lisa)");
            string x = Console.ReadLine();
          
            return x;
        }
    }
}
