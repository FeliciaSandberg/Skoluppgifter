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
            //Skriver ut stj�rnor som �r lika l�ngt som f�rsta ordet + 4 f�r mellanrum
            for (int i = 0; i < input[0].Length + 4; i++)
            {
                Console.Write($"*");
            }
            Console.WriteLine();

            //skriver ut orden p� varsin rad med stj�rnor
            foreach (var item in input)
            {
                Console.WriteLine($"* {item.PadRight(5)} *");
            }

            //skriver ut stj�rnor som �r lika l�ngt som den �vre raden f�r att matcha
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
