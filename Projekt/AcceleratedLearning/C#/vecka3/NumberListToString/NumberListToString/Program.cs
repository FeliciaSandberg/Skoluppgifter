using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberListToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lösning 1 [LINQ]
            string result = ReportFirstAndLastValue(new List<int> {5, 1000, 2000, 3000, 6});
            Console.WriteLine(result);

            //Lösning 2
            string result2Higher = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 105, 150 });
            string result2Lower = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 98, 150 });

            Console.WriteLine(result2Higher);
            Console.WriteLine(result2Lower);

            //Lösning 3
            string result3 = ReportNumberOfNegativeValues(new List<int> { 5, 7, -2, 100, -4 });
            string result3NoNegative = ReportNumberOfNegativeValues(new List<int> { 5, 7, 44, 100, 33 });

            Console.WriteLine(result3);
            Console.WriteLine(result3NoNegative);
            Console.ReadKey();
        }

        private static string ReportNumberOfNegativeValues(List<int> list)
        {
            var lista2 = new List<int>();
            foreach (var item in list)
            {
                if (item < 0)
                {
                    lista2.Add(item);
                }
            }

            if (lista2.Count == 0)
            {
                return "Jippi! Det finns inga negativa tal i listan";
            }

            return $"Det finns {lista2.Count} negativa tal i listan";
        }

        private static string ReportIfAllValuesAreHigherThan100(List<int> list)
        {
            var result = new List<int>();
            foreach (var item in list)
            {
                if (item < 100)
                {
                    return "Något nummer är lägre än 100";
                }
            }
            return "Alla nummer är högre än 100";
            
        }

        private static string ReportFirstAndLastValue(List<int> list)
        {
            var resultFirst = list.Select(x => x).First().ToString();
            var resultLast = list.Select(x => x).Last().ToString();
            
            var result = resultFirst +", " + resultLast;

            return result;
        }
    }
}
