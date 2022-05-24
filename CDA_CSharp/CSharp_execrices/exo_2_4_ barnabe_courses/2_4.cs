using System;

namespace exo_2_4__barnabe_course
{
    class Program
    {
        static void Main(string[] args)
        {
            float sumConsumerSpent; 
            int counterShop = 0;

            Console.WriteLine("how much money barnabe has?");
           
            sumConsumerSpent = float.Parse(Console.ReadLine());

            while (sumConsumerSpent > 0)
            {
                counterShop += counterShop + 1;
                sumConsumerSpent = (sumConsumerSpent / 2) - 1;
            }
            
            Console.WriteLine($"\nbarnabe spent his money in {counterShop} shop(s)");

        }
    }
}
