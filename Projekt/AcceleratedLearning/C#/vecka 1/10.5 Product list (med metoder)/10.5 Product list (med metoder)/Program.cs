using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5_Product_list__med_metoder_
{
    class Program
    {
        static void Main(string[] args)
        {
            var idList = new Dictionary<string, string>();

            while (true)
            {
                string product = GetInputFromUser();
                string[] SplitProducts = SplitString(product);
                idList = AddProductToList(SplitProducts, idList);
                

                if (product == "")
                {
                    foreach (var item in idList)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"Product id = {item.Key} and name = {item.Value}");
                        Console.ResetColor();
                    }
                    break;
                }
            }

            Console.ReadKey();
        }

        private static Dictionary<string, string> AddProductToList(string[] splitProducts, Dictionary<string, string> idList)
        {
            try
            {
                for (int i = 0; i < splitProducts.Length - 1; i += 2)
                {
                    string key = splitProducts[i];
                    string val = splitProducts[(i + 1)];

                    if (key == "" || val == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new ArgumentException($"Product must contain 2 elements");
                    }
                    idList.Add(key, val);
                }
            }

            catch (ArgumentException x)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x.Message);
                Console.ResetColor();
            }
           
            Console.ResetColor();
            return idList;
        }

        private static string[] SplitString(string product)
        {
            string[] SplitProducts = product.Split(',');
            return SplitProducts;
        }

        private static string GetInputFromUser()
        {
            Console.Write("Enter product id and name: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string product = Console.ReadLine();
            Console.ResetColor();

            return product;
        }
    }
}
