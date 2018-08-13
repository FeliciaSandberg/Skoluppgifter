using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Respond_to_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            if (name = "felicia")
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Administrator\Documents\ComputerError.wav");
                player.Play();
            }
            

            Console.Write("How old are you? ");
            string age1 = Console.ReadLine();
            int age = int.Parse(age1);
 
            Console.Write("What is your favorite character? ");
            string letter1 = Console.ReadLine();
            char letter = char.Parse(letter1);

            int retirement = (65 - age);

            Console.WriteLine(Environment.NewLine + "Thank you!" + Environment.NewLine);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("You have " + retirement + " years until retirement");

            if 

            (char.IsNumber(letter))
            Console.WriteLine("You don't like letters"); 

            else
            {
                Console.WriteLine("You don't like numbers");
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
