using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Create_circles__med_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);

            bob.SayHello();
            lisa.SayHello();

            Console.WriteLine();

            bob.WriteArea();
            lisa.WriteArea();

            Console.ReadKey();
        }
    }
}
