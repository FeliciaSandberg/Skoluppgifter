using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Create_circles
{
    class Cube
    {
        public int heigh;
        public int width;
        public int depth;

        public Cube(int h, int w, int d)
        {
            heigh = h;
            width = w;
            depth = d;
        }

        public void WriteVolume()
        {
            int volume = (heigh * width * depth);
            Console.WriteLine("The volume of the cube is " + volume);
        }

        public double CalculateVolume()
        {
            double volume = (heigh * width * depth);
            return volume;
        }


    }
}
