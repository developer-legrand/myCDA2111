using System;

namespace exo_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            int countTryUserInput = 0;
            int numberUserInput;

            do
            {
                Console.WriteLine("\nenter an integer between 1 and 100");
                numberUserInput = int.Parse(Console.ReadLine());
                countTryUserInput++;
                if (randomNumber < numberUserInput)
                {
                    Console.WriteLine($"\nrandom number is smaller than {numberUserInput}");
                    Console.WriteLine($"this is your {countTryUserInput} attempt(s)");
                } else
                {
                    Console.WriteLine($"\nrandom number is bigger than {numberUserInput}");
                    Console.WriteLine($"this is your {countTryUserInput} attempt(s)");
                }

            } while (randomNumber != numberUserInput);

            Console.WriteLine($"\nBravo! random number {numberUserInput}");
            Console.WriteLine($"you find random number in {countTryUserInput} attempt(s)");

        }
    }
}
