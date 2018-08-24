using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringListToBool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "friday", "ooooooooo" });
            bool result2 = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "fri", "ooooooooo" });

          Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.ReadKey();
        }

        private static bool AllWordsAreFiveLettersOrLonger(List<string> list)
        {
            if (list.Count == 0)
            {
                return false;
            }

            bool result = true;

            foreach (var item in list)
            {
                if (item.Length < 5)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
