using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2_Custom_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog buddy = new Dog("Buddy");
            Cat musse = new Cat("Musse");

            DoNiceThings(buddy);
            DoMeanThings(buddy);

            DoNiceThings(musse);


            Console.ReadKey();
        }

        void DoNiceThings(IFriendly Pet)
        {
            Greet();
            ThanksForDinner();
        }


    }
}
