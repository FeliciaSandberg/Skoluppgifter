using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_While
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (name.Length > 10)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                
            }
           
            Console.Write("Times to repeat: ");
            string inmatat = Console.ReadLine();
            int times = int.Parse(inmatat);

            while (times > 15)
            {
                Console.Write("Times to repeat: ");
                inmatat = Console.ReadLine();
                times = int.Parse(inmatat);

            }

            //Console.Write("What is your favorite color? ");
            //string color = Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;

            int i = 0;
            while (times > i++)
            {
                Console.WriteLine("Your name is: " + name);
            }
            Console.ResetColor();

            // if(color == "pink")
            // {
            //     Console.BackgroundColor = ConsoleColor.Black;
            //     Console.ForegroundColor = ConsoleColor.Magenta;
            //     Console.WriteLine("Your name is: " + name);
            //     Console.ResetColor();
            // }
            // else if (color == "yellow")
            // {
            //     Console.BackgroundColor = ConsoleColor.Black;
            //     Console.ForegroundColor = ConsoleColor.Yellow;
            //     Console.WriteLine("Your name is: " + name);
            //     Console.ResetColor();
            // }

            // else if (color == "green")
            // {
            //     Console.BackgroundColor = ConsoleColor.Black;
            //     Console.ForegroundColor = ConsoleColor.Green;
            //     Console.WriteLine("Your name is: " + name);
            //     Console.ResetColor();
            // }

            // else if (color == "red")
            // {
            //     Console.BackgroundColor = ConsoleColor.Black;
            //     Console.ForegroundColor = ConsoleColor.Red;
            //     Console.WriteLine("Your name is: " + name);
            //     Console.ResetColor();
            // }

            // else if (color == "blue")
            // {
            //     Console.BackgroundColor = ConsoleColor.Black;
            //     Console.ForegroundColor = ConsoleColor.Blue;
            //     Console.WriteLine("Your name is: " + name);
            //     Console.ResetColor();
            // }

            // else if (color == "cyan")
            // {
            //     Console.BackgroundColor = ConsoleColor.Black;
            //     Console.ForegroundColor = ConsoleColor.Cyan;
            //     Console.WriteLine("Your name is: " + name);
            //     Console.ResetColor();
            // }

            // else if (color == "white")
            // {              
            //     Console.WriteLine("Your name is: " + name);
            // }

            //else
            // {
            //     Console.WriteLine("your name is: " + name);
            // }




            Console.ReadKey();
        }
    }
}
