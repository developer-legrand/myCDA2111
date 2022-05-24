using System;

namespace tableau_statique_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[10] { 7, 15, 20, 12, 4, 9, 18, 3, 32, 47 };
            AverageArray(myIntArray);
            Console.WriteLine("-----------------------------------------------------");
            IntegerSort(myIntArray);
            Console.WriteLine("-----------------------------------------------------");
        }

        public static void AverageArray(int[] _myIntArray)
        {
            int nbrInteger = 0;
            int sumArrayInteger = 0;
            float result;
            foreach (int value in _myIntArray)
            {
                nbrInteger++;
                sumArrayInteger += value;
            }
            result = (float)sumArrayInteger / nbrInteger;
            Console.WriteLine($"la moyenne du tableau est de : {(float)result}");
        }

        public static void IntegerSort(int[] _myIntArray)
        {
            for (int i = 0; i < _myIntArray.Length - 1; i++)
            {
                for (int j = i + 1; j < _myIntArray.Length; j++)
                {
                    if (_myIntArray[j] < _myIntArray[i])
                    {
                        int temp = _myIntArray[i];
                        _myIntArray[i] = _myIntArray[j];
                        _myIntArray[j] = temp;
                    }
                }
            }
            foreach (int data in _myIntArray)
            {
                Console.WriteLine($"du plus petit au plus grand : {data}");
            }

            int minInteger = _myIntArray[0];
            int maxInteger = _myIntArray[_myIntArray.Length - 1];
            int sumMinMaxInteger = minInteger + maxInteger;
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"le nombre le plus petit est: {minInteger}");
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"le nombre le plus grnad est: {maxInteger}");
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"l'addition du plus petit et du plus grand est: {sumMinMaxInteger}");

        }
    }
}

