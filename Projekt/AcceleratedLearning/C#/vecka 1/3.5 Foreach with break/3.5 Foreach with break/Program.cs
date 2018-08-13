using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5_Foreach_with_break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter names in a list (like Maria,Peter,Anna) ");
            string names = Console.ReadLine();

            Console.Write("Enter lastname: ");
            string lastName = Console.ReadLine();

            List<string> myList = names.Split(',').ToList();

            foreach (var name in myList)
            {
                Console.WriteLine(name + " " + lastName);

                if (name == "zelda")
                {
                    break;
                }

                else if (name == "AllowZelda")
                {
                    myList.Remove("AllowZelda");
                    Console.WriteLine(name + " " + lastName);
                    break;
                }


            }

            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item + " " + lastName);

            //        if (item == "zelda")
            //        {
            //            Console.WriteLine("Value found");
            //            break;
            //        }      
            //}


            Console.ReadKey();
        }
    }
}
