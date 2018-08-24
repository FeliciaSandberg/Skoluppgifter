using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberListToNumberList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lösning 1
            List<int> result = Add100ToEachNumber(new List<int> { 5, 15, 23, 200 });
            foreach (var item in result)
            {
                Console.Write($" * {item}");

            }

            space();
            //Lösning 2
            List<int> result2 = GetNumbersHigherThan1000(new List<int> { 1005, 6, 77, 200000, 666 });
            foreach (var item in result2)
            {
                Console.Write($" * {item}");

            }
            space();
            //Lösning 3
            List<int> result3 = GetNumbersDividableByFive(new List<int> { 20, 5, 6, 7, 10 });
            foreach (var item in result3)
            {
                Console.Write($" * {item}");
            }

            space();
            //Lösning 4
            List<int> result4 = DivideEachNumberBy100(new List<int> { 300, 200, -500, 1000 });
            foreach (var item in result4)
            {
                Console.Write($" * {item}");

            }

            space();
            //Lösning 5
            List<int> result5 = NegateEachNumber(new List<int> { 10, 20, -30, 40 });
            foreach (var item in result5)
            {
                Console.Write($" * {item}");

            }

            space();
            //Lösning 6
            List<int> result6 = Add50ToFirstThreeElements(new List<int> { 6, 16, 23, 200, 300 });
            foreach (var item in result6)
            {
                Console.Write($" * {item}");

            }

            space();
            //Lösning 7
            //List<int> result7 = Add70ToEverySecondElement(new List<int> { 1000, 2000, 3000, 4000, 5000 });


            space();
            //Lösning 8
            List<int> result8 = DivideEachNumberBy100(NegateEachNumber(new List<int> { 300, 200, -500, 1000 }));
            foreach (var item in result8)
            {
                Console.Write($" * {item}");

            }
            Console.ReadKey();
        }

        

        private static List<int> Add50ToFirstThreeElements(List<int> list)
        {
            var result6 = new List<int>();
            foreach (var item in list)
            {
                if (item < 100)
                {
                    int x = item + 50;
                    result6.Add(x);
                }
                else
                {
                    result6.Add(item);
                }
            }
            return result6;

        }

        private static List<int> NegateEachNumber(List<int> list)
        {
            var result5 = new List<int>();
            foreach (var item in list)
            {
                int x = item * -1;
                result5.Add(x);
            }
            return result5;
        }

        private static List<int> DivideEachNumberBy100(List<int> list)
        {
            var result4 = new List<int>();
            foreach (var item in list)
            {
                int x = item / 100;
                result4.Add(x);
            }

            return result4;
        }

        private static void space()
        {
            Console.WriteLine();
        }

        private static List<int> GetNumbersDividableByFive(List<int> list)
        {
            var result3 = new List<int>();
            foreach (var item in list)
            {
                if (item % 5 == 0)
                {
                    result3.Add(item);
                }
            }
            return result3;
        }

        private static List<int> GetNumbersHigherThan1000(List<int> list)
        {
            var result2 = new List<int>();

            foreach (var item in list)
            {
                if (item > 1000)
                {
                    result2.Add(item);
                }
            }

            return result2;
        }

        private static List<int> Add100ToEachNumber(List<int> list)
        {
            var result = new List<int>();
            foreach (var item in list)
            {
                int x = item + 100;
                result.Add(x);
            }
            return result;
        }
    }
}
