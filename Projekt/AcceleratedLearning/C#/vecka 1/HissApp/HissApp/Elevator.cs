using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissApp
{
    class Elevator
    {
        public string Name { get; set; }
        public int LägstaVåning { get; set; }
        public int HögstaVåning { get; set; }
        public int StartVåning { get; set; }
        public int TidTillUnderhåll { get; set; }

        public Elevator(string name, int lägstaVåning, int högstaVåning)
        {
            Name = name;
            LägstaVåning = lägstaVåning;
            HögstaVåning = högstaVåning;
            StartVåning = 5;
            TidTillUnderhåll = 10;
        }

        public Elevator(string name, int lägstaVåning, int högstaVåning, int startVåning, int tidTillUnderhåll)
        {
            Name = name;
            LägstaVåning = lägstaVåning;
            HögstaVåning = högstaVåning;
            StartVåning = startVåning;
            TidTillUnderhåll = tidTillUnderhåll;

        }

        public string PåEllerAV()
        {
            if (TidTillUnderhåll > 0)
            {
                return "På";
            }

            else
            {
                return "av";
            }
        }

        public int GoUp()
        {
            if (StartVåning < HögstaVåning)
            {
                if (TidTillUnderhåll > 0)
                {
                    StartVåning++;
                    TidTillUnderhåll--;
                }
            }


            return StartVåning;
        }

        public int GoDown()
        {
            if (StartVåning > HögstaVåning)
            {
                if (TidTillUnderhåll > 0)
                {
                    StartVåning--;
                    TidTillUnderhåll--;
                }
            }

            return StartVåning;
        }

        public string Report()
        {

            return $"Hissen {Name} är på våning {StartVåning}. Hissen är {PåEllerAV()}. Tills underhåll {TidTillUnderhåll}";

        }
    }
}

