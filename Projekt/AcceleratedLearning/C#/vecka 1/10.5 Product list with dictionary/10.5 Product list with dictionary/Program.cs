using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5_Product_list_with_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var idList = new Dictionary<string, string>();

            while (true)
            {
                Console.Write("Enter product id and name: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                string product = Console.ReadLine();
                Console.ResetColor();

                string[] SplitProducts = product.Split(',');

                for (int i = 0; i < SplitProducts.Length - 1; i += 2)
                {
                    string key = SplitProducts[i];
                    string val = SplitProducts[(i + 1)];

                    idList.Add(key, val);
                }

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

    
        
    }
}
