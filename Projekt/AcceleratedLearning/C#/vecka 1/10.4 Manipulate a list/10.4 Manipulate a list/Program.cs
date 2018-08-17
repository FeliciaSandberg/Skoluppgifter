using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4_Manipulate_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>()
                ;
            while (true)
            {
                Console.Write("Enter a name: ");
                string inmatatNamn = Console.ReadLine();
                Lista.Add(inmatatNamn);

                if (inmatatNamn == "QUIT")
                {
                    Lista.Sort();
                    Lista.Remove("QUIT");
                    Lista.RemoveAt(Lista.Count - 1);
                    Lista.RemoveAt(0);

                    foreach (var name in Lista)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(name);
                        Console.ResetColor();
                    }
                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
