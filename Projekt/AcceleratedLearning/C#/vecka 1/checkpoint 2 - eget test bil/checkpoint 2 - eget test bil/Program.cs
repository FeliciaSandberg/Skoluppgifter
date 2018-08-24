using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint_2___eget_test_bil
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyCars = new List<Car>();

            Console.WriteLine("CarModel, HorsePower, Color : CarModel, HorsePower, Color");
            string Cars = Console.ReadLine();

            string[] SplittedCars = Cars.Trim().Split(':');

            foreach (var car in SplittedCars)
            {
                var Car = new Car();
                var CarString = car.Trim().Split(',');

                Car.Model = CarString[0];
                string horsepower = CarString[1].Replace("hp", "");
                Car.Color = CarString[2];
                Car.HorsePower = int.Parse(horsepower);

                MyCars.Add(Car);
            }

            // skriver ut varje modell
            Header("All cars:");

            int i = 1;
            foreach (var item in MyCars)
            {
                Console.WriteLine($"* Car nr{i} : {item.Model}");
                i++;
            }

            Header("Order by name");

            foreach (var item in MyCars.OrderBy(x => x.Model))
            {
                Console.WriteLine($"Car {item.Model} - {item.HorsePower}hp - Color: {item.Color}");
            }
            
            Header("Order by horsepower:");
            foreach (var item in MyCars.OrderByDescending(x => x.HorsePower))
            {
                Console.WriteLine($"* Model {item.Model} - HorsePower {item.HorsePower}hp");
            }

            Header("Highest hp");
            var HighestHP = MyCars.OrderByDescending(x => x.HorsePower).First();
            Console.WriteLine($"Car {HighestHP.Model}-{HighestHP.HorsePower}hp");

            Header("Lowest hp");
            var LowestHP = MyCars.OrderBy(x => x.HorsePower).First();
            Console.WriteLine($"Car {LowestHP.Model} - {LowestHP.HorsePower}hp");

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
