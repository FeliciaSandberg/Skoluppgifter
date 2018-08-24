using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToStringList
    {

        public void Run()
        {
            /* ------KLAR---1---------------------------------
            
                Lägg till tre stjärnor innan och efter siffran
                
                List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });

                ==>  ***1003***, ***20***, ***-130***, ***2040***
            /* ------KLAR------------------------------------
            

            /* ------KLAR---2---------------------------------
            
                Samma men lägg bara till stjärnor runt de som är större än 1000
             
                List<string> result = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });

                ==>   ***1003***, 20, -130, ***2040***
            /* ------KLAR------------------------------------
            

            /* ------KLAR--3----------------------------------
            /*
                Negativa tal => "ZIP"
                Positiva tal => "ZAP"
                Noll         => "BOING"
            
                List<string> result = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });
 
                =>    ZAP, ZAP, ZIP, BOING, ZAP
            /* ------KLAR------------------------------------
            */

            
            /* ------KLAR--4----------------------------------
              
                Skapa en lista av strängar som meddelar om personen är kort eller lång (över 160cm). Hoppa över orimliga värden

                List<string> result = LongOrShort(new List<int> {170, 130, 205, -10, 600, 180});

                ==>    LÅNG, KORT, LÅNG, LÅNG

            /* ------KLAR------------------------------------
             *

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}