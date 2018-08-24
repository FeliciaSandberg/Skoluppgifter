using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fyra_pandor___del_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = GetinputFromUser();
            WriteInput(input);

            Console.ReadKey();
        }

        private static void WriteInput(string[] input)
        {
            //Skriver ut stjärnor som är lika långt som första ordet + 4 för mellanrum
            for (int i = 0; i < input[0].Length + 4; i++)
            {
                Console.Write($"*");
            }
            Console.WriteLine();

            //skriver ut orden på varsin rad med stjärnor
            foreach (var item in input)
            {
                Console.WriteLine($"* {item.PadRight(5)} *");
            }

            //skriver ut stjärnor som är lika långt som den övre raden för att matcha
            for (int i = 0; i < input[0].Length + 4; i++)
            {
                Console.Write($"*");
            }
        }
        //Ta input och splitta till en array
        private static string[] GetinputFromUser()
        {
            Console.WriteLine("Write input");
            string[] x = Console.ReadLine().Split();
            return x;
        }
    }
}
