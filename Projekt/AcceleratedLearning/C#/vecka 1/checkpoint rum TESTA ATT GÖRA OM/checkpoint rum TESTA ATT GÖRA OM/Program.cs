using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint_rum_TESTA_ATT_GÖRA_OM
{
    class Program
    {
      

        static void Main(string[] args)
        {
            var allaRum = new List<Rum>();

            // få input från användaren:
            Console.WriteLine("Ange namn på rum: ");
            string rumString = "rum1 40m2 | rum2 3m2 | rum3 50m2"; //Console.ReadLine();

            //splittar listan på space + "|" sen drar in den till en lista för
            //att kunna ta bort alla tomma element för att sen gå tillbaka till en array
            string[] splittadLine = rumString.Trim().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
          
            //[item + size] splittar till [0]item + [1]size och in i listan med alla rum
            foreach (var item in splittadLine)
            {

                var items = item.Trim().Split(' ');
                var hem = new Rum();
                hem.Rumnamn = items[0];
                string size = items[1].Replace("m2", "");

                hem.Storlek = int.Parse(size);

                allaRum.Add(hem);
            }


            //skriver ut namnet och antalet rum
            int i = 1;
            foreach (var item in allaRum)
            {
                Console.WriteLine($"* Rumnamn {i}: {item.Rumnamn} ");
                i++;
            }

            // skriver ut det största rummet
            var LargestRoom = allaRum.OrderByDescending(x => x.Storlek).First();
            Console.WriteLine($"Det största rummet är {LargestRoom.Rumnamn} på {LargestRoom.Storlek}m2");

            // skriver ut det minsta rummet
            var SmallestRoom = allaRum.OrderBy(x => x.Storlek).First();
            Console.WriteLine($"Det minsta rummet är {SmallestRoom.Rumnamn} på {SmallestRoom.Storlek}m2");

            Console.ReadKey();
        }
    }
}
