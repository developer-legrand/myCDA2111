using System;

namespace exo_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            
            Console.WriteLine("Enter year to know if it is a leap year?");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine($"you have selected : {year}");

            if ((year%4 == 0) & !(year%100 == 0) | (year%400 == 0)) {
                Console.WriteLine($"{year} is a leap year");
            }

            else Console.WriteLine($"{year} is not a leap year");
            
        }
    }
}
