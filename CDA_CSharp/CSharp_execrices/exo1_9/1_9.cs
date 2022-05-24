using System;

namespace exo1_9
{
    class Program
    {
        static void Main(string[] args)
        {

            int userInput;
            int index;
            int i = 0;
            int[] tabInteger = new int[1];
            
            Console.WriteLine("Enter an integer to find all dividers without 1 and itself");
            userInput = int.Parse(Console.ReadLine());
            
            for(index = 2; index < (userInput - 1); index++)
            {
                if (userInput % index == 0)
                {
                    tabInteger[i] = index;
                    Array.Resize(ref tabInteger, tabInteger.Length + 1);
                    i++;
                }
            }

            if (tabInteger[tabInteger.Length-1] == 0)
            {
                Array.Resize(ref tabInteger, tabInteger.Length - 1);
            }


            foreach (int value in tabInteger)
            {
                Console.WriteLine(value);
            }
        }
    }
}
