using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyra_pandor_del_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = GetinputFromUser();

            foreach (var item in inputArray)
            {
                Console.Write(item + ",");
            }
            Console.ReadKey();
        }

        private static string[] GetinputFromUser()
        {
            Console.WriteLine("write a list of digits: ");
            string input = Console.ReadLine();

            string[] inputArray = input.Select(x => x.ToString()).ToArray();
            
            return inputArray;
        }
    }
}
