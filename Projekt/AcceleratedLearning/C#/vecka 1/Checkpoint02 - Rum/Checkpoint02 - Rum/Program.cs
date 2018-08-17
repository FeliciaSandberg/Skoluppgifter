using System;
using System.Collections.Generic;
using System.Linq;


namespace Checkpoint02___Rum
{
    class Program
    {
        static void Main(string[] args)
        {
            var allaRum = new List<Rum>();

            Console.WriteLine("Ange namn på rum: ");
            string rumString = Console.ReadLine().Trim();


            string[] splittadstring = rumString.Split(' ', '|');
            List<string> ListaMedRum = splittadstring.ToList<string>();
            ListaMedRum.RemoveAll(p => string.IsNullOrEmpty(p));
            splittadstring = ListaMedRum.ToArray();

            for (int a = 0; a < ListaMedRum.Count; a+=2)
            {
                var hem = new Rum();
                hem.Room = ListaMedRum[a];
                

                allaRum.Add(hem);
            }

            for (int b = 1; b < ListaMedRum.Count; b+=2)
            {
                var hem = new Rum();
                hem.Storlek = ListaMedRum[b];
          
                allaRum.Add(hem);
            }
            int i = 1;
            List<Rum> x4 = allaRum.Select(x => new Rum { Room = x.Room }).ToList();
            foreach (var rum in x4)
            {
                Console.WriteLine($"* Rumnamn {i}: {rum.Room} ");
                i++;
            }

         

            allaRum.Sort((a, b) => string.CompareOrdinal(a.Storlek, b.Storlek));
            foreach (var item in allaRum)
            {
                Console.WriteLine($"* Det största rummet är {item.Storlek} ");
                
            }

            Console.ReadKey();
        }
    }
}
