using System;

namespace exo_1_10
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            int userInput;
            int index;
            int[] tabInteger = new int[1];
            int i = 0;
            int result = 0;
            Console.Write("toto");

            Console.WriteLine("Enter an integer to know if it is a perfect number");
            userInput = int.Parse(Console.ReadLine());

            for (index = 1; index < (userInput - 1); index++)
            {
                if (userInput % index == 0)
                {
                    tabInteger[i] = index;
                    Array.Resize(ref tabInteger, tabInteger.Length + 1);
                    i++;
                }
            }

            if (tabInteger[tabInteger.Length - 1] == 0)
            {
                Array.Resize(ref tabInteger, tabInteger.Length - 1);
            }

            /*for (index = 0; index < tabInteger.Length; index++)
            {
                result += tabInteger[index];
            }*/

            foreach (int value in tabInteger)
                result += value;
            
            if (result == userInput)
                Console.WriteLine($"sum of dividers is: {result} it is a perfect number");
            else Console.WriteLine($"sum of dividers is: {result} it is not a perfect number");
        }
    }
}
