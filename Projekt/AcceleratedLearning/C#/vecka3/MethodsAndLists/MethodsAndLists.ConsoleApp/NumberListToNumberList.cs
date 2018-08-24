using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToNumberList
    {
        public void Run()
        {
            // Demo: dubblera alla tal i listan
            // Demo: dubblera alla tal i listan. Hoppa över negativa tal.

            /* ------KLAR-1-----------------------------------
                Addera 100 till varje siffra i listan

                List<int> result = Add100ToEachNumber(new List<int> {5, 15, 23, 200});

                ==> 105, 115, 123, 300
            /* ------KLAR------------------------------------


            /* ------KLAR--2----------------------------------
                Filtrera ut de tal som är högre än 1000
             
                List<int> result = GetNumbersHigherThan1000(new List<int>{1005, 6, 77, 200000, 666});

                ==> 1005, 200000
            /* ------KLAR------------------------------------
             

            
            /* ------KLAR--3----------------------------------
                
                Returnera de tal som är delbara med 5

                List<int> result = GetNumbersDividableByFive(new List<int> { 20, 5, 6, 7, 10 });

                ==> 20, 5, 10
            /* ------KLAR------------------------------------
             

            /* ------KLAR-4-----------------------------------
            
                Dela alla tal i listan med 100

                List<int> result = DivideEachNumberBy100(new List<int> { 300,200,-500,1000 });

                ==> 3, 2, -5, 10
            /* ------KLAR------------------------------------
             


            /* ------KLAR---5---------------------------------
            
                Negera alla tal i listan

                List<int> result = NegateEachNumber(new List<int> { 10, 20, -30, 40 });

                ==> -10, -20, 30, -40
            /* ------KLAR------------------------------------
             

            /* ------KLAR---6---------------------------------
            
                Addera 50 till de tre första elementen i listan
             
                List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16, 23, 200,300 });

                ==> 56, 66, 73, 200, 300

                List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16});
                ==> 56, 66
            /* ------KLAR------------------------------------

             

            /*
                Lägg till 70 till varannat element i listan

                List<int> result = Add70ToEverySecondElement(new List<int> { 1000, 2000, 3000, 4000, 5000});
                ==> 1000, 2070, 3000, 4070, 5000

             */

            /* ------KLAR---3---------------------------------
            
                Experimentera med att kombinera metoder, t.ex såhär:

                List<int> result = DivideEachNumberBy100(NegateEachNumber(new List<int> { 300, 200, -500, 1000 }));
            /* ------KLAR---3---------------------------------
             


            //Console.WriteLine("RESULTAT:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

        }


    }
}