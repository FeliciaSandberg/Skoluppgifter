using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_1
{
    class Product
    {
        public int ID { get; set; }
    }

    class ElectronicBook : Book
    {
        static string SendBookTo(string emailAdress)
        {
            return "Skicka boken till...";
        }
    }

    class Book : Product
    {
        public string Author { get; set; }
        public double NrOfPages { get; set; }
        public string SizeOfBook { get; private set; }
        public string Isbn { get; set; }

        public double WeightInGram()
        {
            double Weight = NrOfPages * 0.8;
            return Weight;
        }

        public string Size()
        {
            if (NrOfPages > 300)
            {
               return "Tjock";
            }
            else if (NrOfPages > 200)
            {
               return "normal";
            }
            else
            {
                return "tunn";
            }

            
        }

    }

   
}
