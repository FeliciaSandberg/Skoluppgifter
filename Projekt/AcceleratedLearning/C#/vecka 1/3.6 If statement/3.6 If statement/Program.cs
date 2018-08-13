using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6_If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine.classify());
            string classify;
            classify = (input > 0) ? "positive" : "negative";

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Compare to number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.ForegroundColor = ConsoleColor.Cyan;

            //if (number < number2)
            //{
            //    Console.WriteLine(number + " is lower than " + number2);
            //}
            //else if (number == number2)
            //{
            //    Console.WriteLine(number + " is equal to " + number2);
            //}
            //else
            //{
            //    Console.WriteLine(number + " is higher than " + number2);
            //}

            // ------------övning 3 -------------------------------

            Random random = new Random();
            int answer = random.Next(0, 100);

            int count = 0;

            Console.Write("Guess a number between 1-100 ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != answer && count < 7)
            {

                if (guess < answer)
                {
                    count++;
                    Console.Write("your number is too low, guess again ");
                    guess = int.Parse(Console.ReadLine());

                }

                else if (guess > answer)
                {
                    count++;
                    Console.Write("your number is too high, guess again ");
                    guess = int.Parse(Console.ReadLine());

                }
            }

            if (count == 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You've lost the game");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You've won! Right answer is: " + answer);
                Console.ResetColor();
            }


            Console.ReadKey();
        }  
        
    }
}
