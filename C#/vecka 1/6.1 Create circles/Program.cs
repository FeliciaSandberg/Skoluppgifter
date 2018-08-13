using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Create_circles
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube mycube = new Cube(2, 3, 4);
            Cube supercube = new Cube(100, 200, 300);

            double volume = mycube.CalculateVolume();
            Console.WriteLine($"Volume: {volume}");

            double supervolume = supercube.CalculateVolume();
            Console.WriteLine($"Volume: {supervolume}");

            //------------------------------------------------
            //Cube mycube = new Cube(2, 3, 4);
            //Cube supercube = new Cube(100, 200, 300);

            //mycube.WriteVolume();
            //supercube.WriteVolume();

            ////-------------------------------------------------
           
            //Circle bob = new Circle("Bob", 8);
            //Circle lisa = new Circle("Lisa", 30);
            //Circle Ali = new Circle("Ali");
            //Circle Unknown = new Circle();

            //bob.SayHello();
            //lisa.SayHello();
            //Ali.SayHello();
            //Unknown.SayHello();

            //Console.WriteLine();

            //bob.WriteArea();
            //lisa.WriteArea();
            //Ali.WriteArea();
            //Unknown.WriteArea();
            
            Console.ReadKey();
        }
    }
}
