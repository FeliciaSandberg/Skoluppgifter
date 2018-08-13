using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaGöraOmprovet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in siffror separerat med ' ' ");
            string nummer = Console.ReadLine();

            List<string> myList = nummer.Split(' ').ToList();

            foreach (var item in myList)
            {
                int itemnummer = int.Parse(item);
                for (int i = 0; i < itemnummer; i++)
                {

                    for (int j = 0; j < itemnummer; j++)
                    {

                        Console.Write("o");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadKey();
        }

    }
}

