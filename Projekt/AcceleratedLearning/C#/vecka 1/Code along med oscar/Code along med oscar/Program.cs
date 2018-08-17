using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code_along_med_oscar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var allShows = new List<Show>();
            var allLines = File.ReadAllLines("TextFile1.txt");

            foreach (var Line in allLines)
            {
               string[] splittedLine = Line.Split('*');
               var channel = splittedLine[0];
               var time = splittedLine[1];
               var title = splittedLine[2];

                var show = new Show();
                show.Title = title;
                show.Channel = channel;
                show.StartAt = TimeSpan.Parse(time);

                allShows.Add(show);
            }
            //-----------------------------------------------------------
            //-----SKRIVER UT ALLA KANALER OCH TITLAR FRÅN LISTAN---------
            //-------------------------------------------------------------
            Header("alla titlar");
            foreach (var show in allShows)
            {
                Console.WriteLine(show.Title);
            }

            Header("alla kanaler");
            foreach (var show in allShows)
            {
                Console.WriteLine(show.Channel);
            }

            //------------------------------------------------------------
            //------GÖR EN NY LISTA MED BARA SHOWS SOM BÖRJAR EFTER 21 ---
            //------------------------------------------------------------

            var laterThan21 = new List<Show>();
            foreach (var show in allShows)
            {
                if (show.StartAt.Hours >= 21)
                {
                    laterThan21.Add(show);
                }
            }
            //-----------------------------------------------------------
            //----SKRIVER UT LISTAN LATER THAN 21 PÅ LÅNGA SÄTTET--------
            //-----------------------------------------------------------
            Header("program som börjar senare än 21");
            foreach (var show in laterThan21)
            {
                Console.WriteLine($"{show.Channel.PadRight(4)} {show.StartAt} {show.Title}");
            }

            //------------------------------------------------------------
            //----SKRIVER UT LISTAN LATER THAN 21 MED LINQ----------------
            //------------------------------------------------------------

            Header("program som börjar senare än 21 med linq");
            foreach (var show in allShows.Where(x => x.StartAt.Hours >= 21))
            {
                WriteInfoAboutShow(show);
            }

            Header("Sorterad lista efter klockslag");
            foreach (var show  in allShows.Where(x => x.Channel == "SVT1").OrderBy(x => x.StartAt))
            {
                WriteInfoAboutShow(show);
            }

            //------------------------------------------------------------
            //----TEST ATT SORTERA LISTAN PÅ ANNAT SÄTT------------------------
            //------------------------------------------------------------

            Header("test");
            allShows.Sort((a, b) => string.CompareOrdinal(a.Title, b.Title));
            foreach (var show in allShows)
            {
                WriteInfoAboutShow(show);
            }

            Console.ReadKey();
        }


        //------------------------------------------------------------
        //----METODER FÖR ATT GÖRA DET FINARE------------------------
        //------------------------------------------------------------

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n {v.ToUpper()} \n");
            Console.ResetColor();
        }

        private static void WriteInfoAboutShow(Show show)
        {
            Console.WriteLine($"{show.Channel.PadRight(4)} {show.StartAt} {show.Title}");
        }

        
    }
}
