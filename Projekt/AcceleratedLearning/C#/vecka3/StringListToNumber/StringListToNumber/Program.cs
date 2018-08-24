using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringListToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = ElevatorGoUpAndDown(new List<string> { "UPP", "NER", "UPP", "UPP" });
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int ElevatorGoUpAndDown(List<string> list)
        {
            int i = 0;
            foreach (var item in list)
            {
                if (item == "UPP")
                {
                    i = i + 1;
                }
                else if (item == "NER")
                {
                    i = i - 1;
                }
            }

            return i;
        }

    }
}
