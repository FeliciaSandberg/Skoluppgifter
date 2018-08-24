using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint03___Listor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nivå 1
            List<int> result = MultipleBy100AndAdd3(new List<int> { 2, 8, 3, 11 });

            //Nivå 2
            List<string> result1 = ReorderList(new List<string> { "a", "b", "c", "d", "e" }, new List<int> { 1, 2, 3, 5, 4 });
            List<string> result2 = ReorderList(new List<string> { "a", "b", "c", "d" }, new List<int> { 3, 1, 4, 2 });
            List<string> result3 = ReorderList(new List<string> { "a", "b" }, new List<int> { 2, 2 });

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nRESULT:\n");
            Console.ResetColor();

            //Skriv ut listorna för att se ifall de fungerar:
            foreach (var item in result)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{item} ");
                Console.ResetColor();
            }

            Console.ReadKey();
        }

        //Metod för Nivå 2
        private static List<string> ReorderList(List<string> letters, List<int> numbers)
        {
            var result1 = numbers.Select(i => letters[i -1]).ToList();

            return result1;
        }

        //Metod för Nivå 1
        private static List<int> MultipleBy100AndAdd3(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var number in list)
            {
                int x = number * 100 + 3;
                result.Add(x);
            }

            return result;
        
        }
    }
}
