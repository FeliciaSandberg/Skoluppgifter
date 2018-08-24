using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class MultipleArguments
    {
        public void Run()
        {
            /*---------Fattar inte-----------------------------------------------------------------------------
                Returnera närliggande elementen i listan. Den första parametern avser index för "mittenelementet".

                List<string> result = NearbyElements(3, new List<string> {"a", "b", "c", "d", "e"});
                ==> c,d,e
            
                List<string> result = NearbyElements(0, new List<string> { "a", "b", "c", "d", "e" });
                ==> a,b

                List<string> result = NearbyElements(4, new List<string> { "a", "b", "c", "d", "e" });
                ==> d,e
            /*---------Fattar inte-----------------------------------------------------------------------------


            /*------KLAR 2--------------------------------------------------------
                Multiplicera alla tal i listan med den första parametern

                List<double> result = MultiplyAllBy(100, new List<double> { 12, 3.14, 50, 99 });
                ==> 1200, 314, 5000, 9900
            /*------KLAR 2--------------------------------------------------------
             

            /*
                Returnera en ny lista där vissa ord är med stora bokstäver. 
                Den andra parmetern är en lista av "bool" som anger vilka som ska vara stora.

                List<string> result = SomeToUpper(new List<string> {"what", "does", "the", "fox", "says"}, new List<bool> {true, false, false, true, true});
                ==> WHAT, DOES, the, fox, SAYS
             */

            //foreach (var element in result)
            //{
            //    Console.WriteLine(element);
            //}
        }

    }
}
