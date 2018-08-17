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
            // Skapa lista "allShapes"
            List<Shape> allShapes = new List<Shape>();

            //Meny för användaren
            while (true)
            {
                Console.WriteLine("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
                string selected = Console.ReadLine().ToUpper();

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

                //Här är programmet klart
                else if (selected == "D")
                {
                    PrintAllShapes(allShapes);
                    ReportAreaOfShape(allShapes);
                    break;
                }

                else
                {
                    Console.WriteLine("Ogiltigt val");
                }
            }
            Console.ReadKey();
        }
        // hämtar arean på varje shape och skriver ut det i en lista
        private static void ReportAreaOfShape(List<Shape> allShapes)
        {
            Console.WriteLine();

            double totalarea = 0;

            foreach (Shape shape in allShapes)
            {
                double area = shape.CalculateArea();
                Console.WriteLine(shape.GetType().Name + ": " + Math.Round(area, 2).ToString());
                totalarea += area;
            }
        }
        // skriver ut vad varje shape är för sort och vad för värden de har
        private static void PrintAllShapes(List<Shape> allShapes)
        {
            Console.WriteLine();

            foreach (Shape shape in allShapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
        // if "C" is selected
        private static Circle AskForCircle()
        {
            Console.Write("Enter redius of circle: ");
            int RadiusOfCircle = int.Parse(Console.ReadLine());
            return new Circle { Radius = RadiusOfCircle };
        }

        // if "R" is selected
        private static Rectangle AskForRectangle()
        {
            Console.Write("Enter width of rectangle: ");
            int WidthOfRectangle = int.Parse(Console.ReadLine());
            Console.Write("Enter height of rectangle: ");
            int HeightOfRectangle = int.Parse(Console.ReadLine());

            return new Rectangle { Width = WidthOfRectangle, Height = HeightOfRectangle };
        }

        // if "T" is selected
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
