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
        public ElectronicBook(string isbun, string minbok) : base(isbun, minbok)
        {

        }

        public void SendBookTo(string emailAdress)
        {
            Console.WriteLine($"   Send book to {emailAdress}");
        }
    }

    class Book : Product
    {

        public Book(string isbn, string minBok) 
        {
            
        }
       
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
