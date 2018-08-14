using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Setup_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> allShapes = new List<Shape>();


            while (true)
            {
                Console.WriteLine("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
                Console.WriteLine();
                string selected = Console.ReadLine();

                if (selected == "T")
                {
                    allShapes.Add(AskForTriangle());
                }

                else if (selected == "R")
                {
                    allShapes.Add(AskForRectangle());
                }

                else if (selected == "C")
                {
                    allShapes.Add(AskForCircle());
                }

                else if (selected == "D")
                {
                    foreach (var shape in allShapes)
                    {
                        shape.GetType().Name, Math.Round(area, 2).ToString();
                        totalArea += area;
                    }
                   
                    break;
                }

                else
                {
                    Console.WriteLine("Ogiltigt val");
                }

            }

            Console.ReadKey();     
        }

        private static Circle AskForCircle()
        {
            Console.Write("Enter redius of circle: ");
            int RadiusOfCircle = int.Parse(Console.ReadLine());
            return new Circle { Radius = RadiusOfCircle };
        }

        private static Rectangle AskForRectangle()
        {
            Console.Write("Enter width of rectangle: ");
            int WidthOfRectangle = int.Parse(Console.ReadLine());
            Console.Write("Enter height of rectangle: ");
            int HeightOfRectangle = int.Parse(Console.ReadLine());

            return new Rectangle { Width = WidthOfRectangle, Height = HeightOfRectangle };
        }

        private static Triangle AskForTriangle()
        {
            Console.Write("Enter base of triangle: ");
            int BaseOfTriangle = int.Parse(Console.ReadLine());
            Console.Write("Enter height of triangle: ");
            int HeightOfTriangle = int.Parse(Console.ReadLine());

            return new Triangle { Width = BaseOfTriangle, Height = HeightOfTriangle };
        }

    }
}
