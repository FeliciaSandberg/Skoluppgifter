using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyra_pandor___del_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotateIndex = 4;
            int joinedString;

            int[] intArray = new int[] { 100, 200, 300, 400, 500, 600 };

            List<int> rightPartOfList = new List<int>();

            for (int i = rotateIndex; i <= intArray.Length - 1; i++)
            {
                int x = intArray[i];
                rightPartOfList.Add(x);
            }

            List<int> LeftPartOfList = new List<int>();

            for (int i = 0; i < intArray.Length - 2 ; i++)
            {
                int x = intArray[i];
                LeftPartOfList.Add(x);
            }

            LeftPartOfList.AddRange(rightPartOfList);

            
            foreach (var item in LeftPartOfList)
            {
                Console.Write($" {item}");
            }

            Console.ReadKey();
        }
    }
}
