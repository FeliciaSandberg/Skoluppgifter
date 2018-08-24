using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lösning 1
            List<string> result = NearbyElements(3, new List<string> { "a", "b", "c", "d", "e" });
            List<string> result2 = NearbyElements(0, new List<string> { "a", "b", "c", "d", "e" });
            List<string> result3 = NearbyElements(4, new List<string> { "a", "b", "c", "d", "e" });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //Lösning 2
            List<double> result4 = MultiplyAllBy(100, new List<double> { 12, 3.14, 50, 99 });
            foreach (var item in result4)
            {
                Console.Write(item + ", ");
            }

            //Lösning 3
            List<string> result5 = SomeToUpper(new List<string> { "what", "does", "the", "fox", "says" }, new List<bool> { true, false, false, true, true });

            Console.ReadKey();
        }

        private static List<string> SomeToUpper(List<string> list1, List<bool> list2)
        {
            int x = 0;

            for (int i = 0; i < list1.Count; i++)
            {
                list1[i] = list2[i];
            }
        }

        private static List<double> MultiplyAllBy(int v, List<double> list)
        {
            var result4 = new List<double>();
            foreach (var item in list)
            {
               double x = item * v;
                result4.Add(x);
            }

            return result4;
        }

        private static List<string> NearbyElements(int y, List<string> list)
        {
            int x = list.Count - y;

            var result = list.Skip(y).Take(x).ToList();
            return result;
           
        }
    }
}
