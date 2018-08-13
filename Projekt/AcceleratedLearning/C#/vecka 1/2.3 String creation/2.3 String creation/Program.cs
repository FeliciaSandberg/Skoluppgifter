using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_String_creation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();

            Console.Write("How many fruits do you want to add? ");
            string inmatat1 = Console.ReadLine();
            int tal1 = int.Parse(inmatat1);
            for (int i = 0; i < tal1; i++)

            {
                Console.Write("Enter a fruit ");
                fruits.Add(Console.ReadLine());
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("you have entered " + inmatat1 + " fruits ");

            for (int i = 0; i < fruits.Count; i++)
            {
                string itemsInList = fruits[i];
                Console.Write(itemsInList + ", ");

            }
            

           

            //Console.Write("Enter fruit 1: ");
            //string fruit1 = Console.ReadLine();
            //Console.Write("Enter fruit 2: ");
            //string fruit2 = Console.ReadLine();
            //Console.Write("Enter fruit 3: ");
            //string fruit3 = Console.ReadLine();

            //String result2 = String.Format("You entered three fruits {0}, {1}, {2}!", fruit1, fruit2, fruit3);
            //var result = $"You entered three fruits {fruit1}, {fruit2}, {fruit3}!";
            

            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.Yellow;

            //Console.WriteLine(result2);
            //Console.WriteLine("You entered three fruits " + fruit1 + ", " + fruit2 + ", " + fruit3 + "!");
            //Console.WriteLine(result);

            
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
