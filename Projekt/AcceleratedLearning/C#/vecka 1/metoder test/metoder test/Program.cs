using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Lisa = "Lisa";
            SayHello(Lisa);
            string names = TripplarStr�ngar(Lisa);
        }

        private static void SayHello(string name)
        {
            Console.WriteLine("hello" + name);
        }

        private static string TripplarStr�ngar(string name)
        {
            return name + name + name;
        }

        
    }
}
