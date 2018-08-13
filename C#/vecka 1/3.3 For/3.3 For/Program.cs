using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How many rows? ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("How many columns? ");
            int columns = int.Parse(Console.ReadLine());

            //Console.Write(name + "      " + name + "      " + name +
            //Environment.NewLine + name + "      " + name + "      " + name);
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < columns; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < row; j++)
                {
                    
                    Console.Write(name + "      ");
                }
                
            }

            Console.ReadKey();
        }
    }
}
