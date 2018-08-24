using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyra_pandor___del_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> abc = new List<string>() { "a", "b", "c" };
            List<string> numbers = new List<string>() { "1", "2", "3" };
            List<string> combine = new List<string>();

            CombineTwoLists(abc, numbers, combine);
           

            Console.ReadKey();
        }


        private static void CombineTwoLists(List<string> abc, List<string> numbers, List<string> combine)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                combine.Add(abc[i]);
                combine.Add(numbers[i]);
            }

            foreach (var item in combine)
            {
                Console.Write($"{item},");
            }
            
        }
    }
}
