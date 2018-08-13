using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter names in a list (like Maria,Peter,Anna) ");
            string myString = Console.ReadLine();

            Console.Write("Enter lastname: ");
            string lastName = Console.ReadLine();

            List<string> myList = myString.Split(',').ToList();
            foreach (var item in myList)
            {
                Console.WriteLine(item + " " + lastName);
            }
            Console.ReadKey();

            // ------- TA BORT NAMN ------------------------

            Console.Write(Environment.NewLine + "Delete a name: ");
            string delete = Console.ReadLine();

            Console.WriteLine();

            myList.Remove(delete);
            foreach (var item in myList)
            {
                Console.WriteLine(item + " " + lastName);
            }

            Console.ReadKey();
        }

    }
}
