using System;

namespace tableau_statique_entier
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomStaticArray();
        }


        public static void RandomStaticArray()
        {
            Random random = new Random();
            int[] myRandomArray;
            int nbrValueArray;
            int nbrRowArray;
            nbrRowArray = random.Next(1, 21);
            myRandomArray = new int[nbrRowArray];
            for (int i = 0; i < myRandomArray.Length; i++)
            {
                nbrValueArray = random.Next(-50, 51);
                myRandomArray[i] = nbrValueArray;
            }
            for (int j = 0; j < myRandomArray.Length; j++)
            {
                Console.WriteLine(myRandomArray[j]);
            }

        }
    }
}

