using System;
using System.Collections;

namespace exo_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string nbInput;
            ArrayList arrayNumber = new ArrayList();
            int index;
            index = 0;
            
            do
            {
                Console.WriteLine("Enter a number");
                nbInput = (Console.ReadLine());
                arrayNumber.Add(nbInput);
                index += 1;

            }

            while (index <= 2);
            arrayNumber.Sort();
            Console.WriteLine();
            Console.WriteLine("Les éléments après le tri :");
            foreach (string i in arrayNumber)
                Console.WriteLine(i);
        }
    }
}

            //-----------------------------------------------------------------------------------------------------------------------//
      /*      Console.WriteLine("arrayNumber");
            Console.WriteLine("    Count:    {0}", arrayNumber.Count);
            Console.WriteLine("    Capacity: {0}", arrayNumber.Capacity);
            PrintValues(arrayNumber);

        }*/


      /*  public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }*/

