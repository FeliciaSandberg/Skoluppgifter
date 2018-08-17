using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Setup_classes
{

    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public abstract double CalculateArea();

        public override string ToString()
        {
            return "I'm a shape";
        }
    }
    class Triangle : Shape
    {
        public override double CalculateArea()
        {
            return Width * Height / 2;
        }

        public override string ToString()
        {
            return $"I'm triangle with height={Height} and width={Width}";
        }
    }

    class Circle : Shape
    {
        public int Radius { get; set; }

        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override string ToString()
        {
            return $"I'm a rectangle with radius {Radius}";
        }
    }

    class Rectangle : Shape
    {
        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"I'm a rectangle with height={Height} and width={Width}";
        }
    }
}
