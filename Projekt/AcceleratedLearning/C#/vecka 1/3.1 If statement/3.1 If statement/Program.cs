using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_If_statement
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("When did you go to bed yesterday? ");
            string WentToBed = Console.ReadLine();
            int BedTime = int.Parse(WentToBed);

            Console.Write("When did you wake up? ");
            string WakeUp = Console.ReadLine();
            int WakeTime = int.Parse(WakeUp);

            int SleepTime = (24 - BedTime + WakeTime);

            if (SleepTime < 6)
            {

            }

            Console.WriteLine("you have slept " + SleepTime);

            Console.ReadKey();



        }
    }
}
