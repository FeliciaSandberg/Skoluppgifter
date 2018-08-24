using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_02___omprov
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyFurniture = new List<Furniture>();

            Console.WriteLine("Varje m�bel anges i f�ljande format d�r namnet och priset �r separerat med kommatecken.");
            Console.WriteLine("NamnP�M�bel,Pris");
            string furnitureString = "F�t�lj,1584:Billy bokhylla,299:Kallax hyllserie,899:Klippan-soffan,1795"; //Console.ReadLine();

            var furnitureSplitString = furnitureString.Trim().Split(':');

            foreach (var item in furnitureSplitString)
            {
                var Furniture = new Furniture();
                var SplitIntoObjects = item.Split(',');

                Furniture.Name = SplitIntoObjects[0];
                Furniture.Price = int.Parse(SplitIntoObjects[1]);

                MyFurniture.Add(Furniture);
            }

            Header("Den billigaste produkten:");
            var CheapestFurniture = MyFurniture.OrderBy(x => x.Price).First();
            Console.WriteLine($"Den billigaste produkten �r '{CheapestFurniture.Name}' och den kostar {CheapestFurniture.Price}kr");

            Header("den dyraste produkten:");
            var MostExpensiveFurniture = MyFurniture.OrderByDescending(x => x.Price).First();
            Console.WriteLine($"Den dyraste produkten �r '{MostExpensiveFurniture.Name}' och den kostar {MostExpensiveFurniture.Price}kr");

            Header("Produkter sorterad p� namn");
            int i = 1;
            foreach (var item in MyFurniture.OrderBy(x => x.Name))
            {
                Console.WriteLine($"* {i}: {item.Name.PadRight(20)} - {item.Price}kr");
                i++;
            }

            Console.ReadKey();
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{v.ToUpper()}\n");
            Console.ResetColor();
        }
    }
}
