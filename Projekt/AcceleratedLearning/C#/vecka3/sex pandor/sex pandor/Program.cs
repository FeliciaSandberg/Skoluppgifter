using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sex_pandor
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetInPutFromUser();
            string pigLatin = ToPigLatin(input);

            Console.WriteLine(pigLatin);

            Console.ReadKey();
        }

        private static string ToPigLatin(string input)
        {
            const string vowels = "AEIOUaeio";
            List<string> pigWords = new List<string>();

            foreach (string word in input.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    pigWords.Add(restOfWord + firstLetter + "ay");
                }
                else
                {
                    pigWords.Add(word + "way");
                }
            }
            return string.Join(" ", pigWords);
        }

        private static string GetInPutFromUser()
        {
            Console.WriteLine("Write a sentence and I'll translate it to pig latin: ");
            string x = "The quick brown fox"; // Console.ReadLine();

            return x;
        }
    }
}
