using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Create_circles__med_metoder
{
    class Circle
    {
        public double radius { get; set; }
        public string name { get; set; }

        public Circle (string x, double y)
        {
            name = x;
            radius = y;
        }

        public void SayHello()
        {
            Console.WriteLine($"I'm a circle with the name {name}! ");
        }

        public void WriteArea()
        {
            double pi = Math.PI;
            double area = Math.Round(pi * (radius * radius), 2);

            Console.WriteLine($"My name is {name}. I have radius of {radius} and an area of {area}");
        }
    }
}
