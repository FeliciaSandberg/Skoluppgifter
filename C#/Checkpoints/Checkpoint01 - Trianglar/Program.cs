using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01___Trianglar
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Mata in siffror separerat med '-' ");
            string nummer = Console.ReadLine();

            List<string> myList = nummer.Split('-').ToList();

            foreach (var item in myList)
            { 
                int itemnummer = int.Parse(item);
                for (int i = 1; i <= itemnummer; i++)
                {
                    for (int t = 1; t <= i; t++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }

       
    }
}





            