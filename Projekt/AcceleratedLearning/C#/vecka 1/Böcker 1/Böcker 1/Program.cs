using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book();

            b1.Isbn = "978-3-16-148410-0";
            b1.Author = "Kalle";
            b1.NrOfPages = 400;
            b1.ID = 1234;

            var e1 = new ElectronicBook();


            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:            {b1.Isbn}");
            Console.WriteLine($"   Författare:      {b1.Author}");
            Console.WriteLine($"   Antal sidor:     {b1.NrOfPages}");
            Console.WriteLine($"   Vikt:            {b1.WeightInGram()} gram");
            Console.WriteLine($"   Storlek:         {b1.Size()}");
            Console.WriteLine($"   Produktens ID:   {b1.ID}");
            Console.WriteLine();

            bool isBook = b1 is Book;
            bool isb1Ebook = b1 is ElectronicBook;
            bool isb1product = b1 is Product;

            bool e1book = e1 is Book;
            bool e1isEbook = e1 is ElectronicBook;
            bool e1isproduct = e1 is Product;

            Console.WriteLine("Olika test:");
            Console.WriteLine();
            Console.WriteLine($"   Är b1 en bok?     {isBook}");
            Console.WriteLine($"   Är b1 en e-bok?   {isb1Ebook}");
            Console.WriteLine($"   Är b1 en produkt? {isb1product}");
            Console.WriteLine();
            Console.WriteLine($"   Är e1 en bok?     {e1book}");
            Console.WriteLine($"   Är e1 en e-bok?   {e1isEbook}");
            Console.WriteLine($"   Är e1 en produkt? {e1isproduct}");

            Console.WriteLine(Environment.NewLine + "Anrop:");
           

            Console.ReadKey();
            
        }
    }
}
