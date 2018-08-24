using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberListToStringList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lösning 1
            List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });
            foreach (var item in result)
            {
                Console.Write(item + ",");
            }
            space();
            //Lösning 2
            List<string> result2 = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });
            foreach (var item in result2)
            {
                Console.Write(item + ",");
            }

            space();
            //Lösning 3
            List<string> result3 = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });
            foreach (var item in result3)
            {
                Console.Write(item + ",");

            }

            space();
            //Lösning 4
            List<string> result4 = LongOrShort(new List<int> { 170, 130, 205, -10, 600, 180 });
            foreach (var item in result4)
            {
                Console.Write(item + ",");

            }
            Console.ReadKey();
        }

        private static List<string> LongOrShort(List<int> list)
        {
            var result4 = new List<string>();
            foreach (var item in list)
            {
                if (item > 160)
                {
                    string a = "LÅNG";
                    result4.Add(a);
                }
                else
                {
                    string b = "KORT";
                    result4.Add(b);
                }
            }
            return result4;
        }

        private static List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> list)
        {
            var result3 = new List<string>();

            foreach (var item in list)
            {
                if (item < 0)
                {
                    string a = "ZIP";
                    result3.Add(a);
                }
                else if (item > 0)
                {
                    string b = "ZAP";
                    result3.Add(b);
                }
                else if (item == 0)
                {
                    string c = "BOING";
                    result3.Add(c);
                }
            }
            return result3;
        }


        private static void space()
        {
            Console.WriteLine();
        }

        private static List<string> AddStarsToNumbersHigherThan1000(List<int> list)
        {
            var result2 = new List<string>();
            foreach (var item in list)
            {
                if(item > 1000)
                {
                    string x = $"***{item}***";
                    result2.Add(x);
                }
                else
                {
                    result2.Add(item.ToString());
                }
            }

            return result2;
        }

        private static List<string> AddStars(List<int> list)
        {
            var result = new List<string>();
            foreach (var item in list)
            {
                string x = $"***{item}***";
                result.Add(x);
            }

            return result;
        }
    }
}
