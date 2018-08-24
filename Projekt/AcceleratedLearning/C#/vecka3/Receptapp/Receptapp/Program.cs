using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Receptapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fil med alla recept
            var allRecipes = File.ReadAllLines("Recept.txt").ToList();
            //Meny
            while (true)
            {
                Console.WriteLine($"- - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine($"| [M] - Mata in ingredienser          |");
                Console.WriteLine($"| [V] - Visa alla tillgängliga recept |");
                Console.WriteLine($"| [Q] - Quit                          |");
                Console.WriteLine($"- - - - - - - - - - - - - - - - - - - -");


                string answer = Console.ReadLine().ToUpper();

                if (answer == "M")
                {
                    Console.Clear();
                    //Få ingredienser från användaren
                    List<string> ingredients = GetIngredientsFromUser();
                    //Matcha användarens input med receptfilen
                    int index = CountMatchingIngrediences(allRecipes, ingredients);
                    //Skriva ut vilket recept som matchar bäst
                    WriteOutRecipe(index, allRecipes, ingredients);

                    break;
                }
                else if (answer == "V")
                {
                    Console.Clear();
                    //Visar alla recept som finns tillgängliga 
                    List<string> NamesOfFood = new List<string>();
                    for (int i = 0; i < allRecipes.Count; i++)
                    {
                       var ingredients = allRecipes[i].Split(',');
                       string nameOfFood = ingredients[0];

                        NamesOfFood.Add(nameOfFood);
                    }

                    foreach (var item in NamesOfFood)
                    {
                        Header($" {item}");
                    }
                }
                
                //Avslutar programmet:
                else if (answer == "Q")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"********** \n* HEJDÅ! *\n**********");
                    Console.ResetColor();

                    break;
                }
                else
                {
                    RedText("Inkorrekt menyval");
                }
            }

            Console.ReadKey();
        }

        private static void AsciiArt(string v)
        {
            Console.WriteLine(@"                    ___          /");
            Console.WriteLine(@"       ||||     -´´`   `´´-     } |  __");
            Console.WriteLine(@"  |||| ||||   .'  .-'`'-.  '.   } | /  \");
            Console.WriteLine(@"  |||| \  /  /  .'       '.  \  } | ;();");
            Console.WriteLine(@"  \  /  ||  /  ;           ;  \  \| \  /");
            Console.WriteLine(@"   ||   ||  | ;             ; |  ||  ||");
            Console.WriteLine(@"   %%   %%  | ;             ; |  %%  %%");
            Console.WriteLine(@"   %%   %%  \  ;           ;  /  %%  %%");
            Console.WriteLine(@"   %%   %%   \  '.       .'  /   %%  %%");
            Console.WriteLine(@"   %%   %%    '.  `-.,.-'  .'    %%  %%");
            Console.WriteLine(@"   %%   %%      '-.,___,.-'      %%  %%");


        }

        private static void WriteOutRecipe(int index, List<string> allRecipes, List<string> ingredientsInput)
        {
            if (index == -1)
            {
                RedText("Du har för få ingredienser som matchar ett recept :(");
            }

            else
            {
                //Splitta receptet till ingredienser
                var ingredients = allRecipes[index].Split(',');

                //Lista med saknade ingrediensesr:
                List<string> missingIngredients = new List<string>();

                foreach (var item in ingredients)
                {
                    if (!ingredientsInput.Contains(item))
                    {
                        missingIngredients.Add(item);
                    }
                }

                //skriv ut namnet på maträtten
                Console.WriteLine($"\n Du kan laga:");
                Header(" " + ingredients[0]);

                //skriv ut stjärnor på översta raden
                Console.Write($"* * * * * * * * *");
                Console.WriteLine();

                //skriv ut varje ingrediens
                for (int i = 1; i < ingredients.Length; i++)
                {
                    Console.WriteLine("*".PadRight(3) + "-" + ingredients[i].PadRight(12) + "*");
                }

                //skriv ut stjärnor på nedersta raden
                Console.Write($"* * * * * * * * *");

                //Skriv ut vilka ingredienser du saknar:
                Header2("\n men Du saknar dessa ingredienser:");
                for (int i = 1; i < missingIngredients.Count; i++)
                {
                    Console.Write($" -{missingIngredients[i]} \n");
                }
                //skriv ut ascii bild
                AsciiArt($"\n");

            }
        }

        //Skriver ut gul rubrik
        private static void Header2(string v)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{v.ToUpper()}");
            Console.ResetColor();
        }

        //Skriver ut gul rubrik med mellanrum
        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{v.ToUpper()}\n");
            Console.ResetColor();
        }
       
        //Användaren matar in vilka ingredienser de har hemma
        private static List<string> GetIngredientsFromUser()
        {
            while (true)
            {
                Console.WriteLine("Lista upp dina ingredienser separerade med ',' : ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string input = Console.ReadLine().ToLower();
                Console.ResetColor();

                if (input.Length == 0)
                {
                    RedText("Du har inte skrivit in någon ingrediens!");
                }
                else if (!Regex.IsMatch(input, "^[a-öA-Ö,]+$"))
                {
                    RedText("Du har skrivit in ett inkorrekt tecken");
                }
                else
                {
                    List<string> ingredients = input.Split(',').ToList();
                    return ingredients;
                }
            }
        }

       
        //Skriver ut röd varningstext
        private static void RedText(string v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(v);
            Console.ResetColor();
        }

        //Ser vilka recept som innehåller användarens ingredienser
        private static int CountMatchingIngrediences(List<string> allRecipe, List<string> ingredients)
        {
            int qty = 0;
            int index = -1;

            for(int i = 0; i < allRecipe.Count; i++)
            {
                var SplitItem = allRecipe[i].Split(',').ToList();
                int currentQty = MatchingIngredients(SplitItem, ingredients);
                
                if (currentQty > 2)
                {
                    qty = currentQty;
                    index = i;
                }
            }
            return index;
        }

        //Räknar antalet matchningar
        private static int MatchingIngredients(List<string> recipe, List<string> ingredients)
        {
            var qtyMatch = recipe.Intersect(ingredients);
            return qtyMatch.Count();
        }
    }
}
