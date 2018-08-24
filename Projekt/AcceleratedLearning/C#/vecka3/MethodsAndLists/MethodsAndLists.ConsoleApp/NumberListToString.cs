using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToString
    {

        public void Run()
        {


            /* ------KLAR---1---------------------------------
            
                Returnera en text som talar om vilket det första och sista numret är i listan

                string result = ReportFirstAndLastValue(new List<int> {5, 1000, 2000, 3000, 6});

                ==>    Första siffran är 5 och sista siffran är 6
            /* ------KLAR------------------------------------
             

            /* ------KLAR---2---------------------------------
            
                Returnera en text som säger om alla nummer är högre än 100 eller inte.

                string result = ReportIfAllValuesAreHigherThan100(new List<int> {200, 105, 150});
                ==>    Alla nummer är högre än 100

                string result = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 98, 150 });
                ==>    Något nummer är lägre än 100
            /* ------KLAR------------------------------------

            /* ------KLAR---3---------------------------------

                Returnera en text hur många negativa tal som finns i listan

                string result = ReportNumberOfNegativeValues(new List<int> {5, 7, -2, 100, -4});
                ==>     Det finns 2 st negativa tal i listan

                string result = ReportNumberOfNegativeValues(new List<int> { 5, 7, 44, 100, 33 });
                ==>     Jippi! Det finns inga negativa tal i listan
            /* ------KLAR---2---------------------------------
             


            //Console.WriteLine("RESULT");
            //Console.WriteLine(result);

        }

    }
}
 