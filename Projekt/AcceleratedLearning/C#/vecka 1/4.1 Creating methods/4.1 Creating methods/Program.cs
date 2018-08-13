using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4._1_Creating_methods
{
    class Program
    {


        static void Main(string[] args)
        {
            // Get input
            string inmatadeNamn = GetInput();
            // convert to array
            string[] splittadeNamn = MyListOfNames(inmatadeNamn);
            // trim values
            List<string> TrimmadeNamn = CleanUpArray(splittadeNamn);
            // Check if values are ok
            if (PeopleArrayIsValid(TrimmadeNamn.ToArray()))
            {
                WriteList(TrimmadeNamn.ToArray());
            }
            else
            {
                Console.WriteLine("values are not correct");
            }

            Console.ReadKey();
        }

        private static bool PeopleArrayIsValid(string[] peopleArray)
        {
            bool allIsValid = true;

            Regex reg = new Regex("^[a-zA-ZÂ‰ˆ≈ƒ÷]+$");

            // DO STUFF
            foreach (string item in peopleArray)
            {
                if (string.IsNullOrEmpty(item))
                {
                    allIsValid = false;
                    break;
                }

                if (!reg.IsMatch(item))
                {
                    allIsValid = false;
                    Console.WriteLine("value " + item + " is not valid");
                    break;
                }

            }

            return allIsValid;
        }

        private static List<string> CleanUpArray(string[]TrimmadeNamn)
        {
            List<string> trimmad = new List<string>();

            foreach (string element in TrimmadeNamn)
            {
                string cleanedElement = element.Trim();
                trimmad.Add(cleanedElement);
            }
            return trimmad;
        }

        private static string GetInput()
        {
            Console.Write("Enter names seperated by ',' (ex: Hanna,Johan,Peter) ");

            string names = string.Empty;
            bool a = true;
            bool b = true;
            bool rightValueEntered = false;

            do
            {
                rightValueEntered = false;
                names = Console.ReadLine();
                if (!string.IsNullOrEmpty(names))
                {
                    string[] arr = names.Split(',');

                    bool foundError = false;
                    foreach (string name in arr)
                    {
                        a = (name.Length < 2 || name.Length > 9);
                        b = (name.Length == 0);

                        if (a)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("A name can only have 2-9 letters ");
                            Console.ResetColor();
                            foundError = true;                         
                            break;
                        }
                        else if (b)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The list don't contain any names");
                            Console.ResetColor();
                            foundError = true;
                            break;
                        }
                    }

                    rightValueEntered = !foundError;
                }
            }
            while (rightValueEntered == false);

            ///////////////////////


            //string names = Console.ReadLine();

            //names.Split(',');

            //bool a = true;
            //bool b = true;
            //a = (names.Length < 2 || names.Length > 9);
            //b = (names.Length == 0);

            //while (a == true || b == true)
            
            //    if (a)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("A name can only have 2-9 letters ");
            //        Console.ResetColor();
            //        names = Console.ReadLine();
            //        names.Split(',');
            //        break;

            //    }
            //    else if (b)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("The list don't contain any names");
            //        Console.ResetColor();
            //        names = Console.ReadLine();
            //        names.Split(',');
            //        break;
            //    }
            

            return names;
        }

        public static string[] MyListOfNames(string input)
        {
            return input.Split(',');
        }

        public static void WriteList(string[] peopleArray)
        {
            
            foreach (var item in peopleArray)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***SUPER-" + item.ToUpper() + "***");

            }

        }
    }
}
