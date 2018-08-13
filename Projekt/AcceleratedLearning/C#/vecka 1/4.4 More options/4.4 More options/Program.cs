using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4._4_More_options
{
    class Program
    {
        static void Main(string[] args)
        {
            char separator = AskUserForSeparator();
            bool ErrorMessage = AskUserForErrorMessage();
            string names = GetInput();
            string[] list = SplitIntoList(names,separator);
            List<string> CompleteList = CreateList(list);
            bool namesArray = PeopleArrayIsValid(CompleteList, ErrorMessage);

            if (PeopleArrayIsValid(CompleteList, ErrorMessage))
            {
                WriteList(CompleteList);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Value not correct");
                Console.ResetColor();

            }


            Console.ReadKey();
        }


        // --- Ta emot inmatat, konvertera till array, kolla errors----
        private static string GetInput()
        {
           

            Console.Write("Enter names with your separator (ex: Hanna,Johan,Peter) ");
            string names = Console.ReadLine();

            return names;
        }

        // ------ Let the user select a seperator ----------------
        private static char AskUserForSeparator()
        {
            Console.Write("Which separator do you want to use (default is comma) ? ");
            char separator = char.Parse(Console.ReadLine());

            return separator;
        }

        // ----- Ask user if he/she want to see errors-----------
        private static bool AskUserForErrorMessage()
        {

            Console.Write("Do you want to see error messages (default is yes) ? ");
            string WantToSeeErrors = Console.ReadLine();

            if (WantToSeeErrors == "no")
            {
                return false; 
            }
            else
            {
                return true;
            }
        }

        private static bool PeopleArrayIsValid(List<string> peopleArray, bool YesOrNo)
        {  
            bool allIsValid = true;

            Regex reg = new Regex("^[a-zA-ZÂ‰ˆ≈ƒ÷]+$");

            // DO STUFF
            foreach (string item in peopleArray)
            {
                if (string.IsNullOrEmpty(item))
                {
                    allIsValid = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have not entered any letters...");
                    Console.ResetColor();
                    break;
                }

               else if (!reg.IsMatch(item))
                {
                    allIsValid = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("value " + item + " is not valid");
                    Console.ResetColor();
                    break;
                }
                else if (item.Length < 2 || item.Length > 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A name can only have 2-9 letters ");
                    Console.ResetColor();
                }
            }

            return allIsValid;
        }
        public static void WriteList(List<string> peopleArray)
        {

            foreach (var item in peopleArray)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***SUPER-" + item.ToUpper() + "***");

            }

        }

        private static List<string> CreateList(string[] list)
        {
            List<string> completeList = new List<string>();

            foreach (string element in list)
            {
                string cleanedElement = element.Trim();
                completeList.Add(cleanedElement);
            }
            return completeList;
        }

        public static string[] SplitIntoList(string names, char separator)
        {
            return names.Split(separator);
        }


    }
}
