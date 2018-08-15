using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8._2_Files_and_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a file name: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    File.CreateText(Console.ReadLine());
                    Console.ResetColor();

                    Console.WriteLine($"The file is now created");
                    break;
                }
                catch (FormatException x)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(x.Message);
                    Console.ResetColor();
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                catch (ArgumentException x)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(x.Message);
                    Console.ResetColor();
                }
                catch (Exception x)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(x.Message);
                    Console.ResetColor();
                }

               
            }
            

            Console.ReadKey();
        }
    }
}
