using System;

namespace tableau_statique_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string userQuestion = "";
            int userArraySize;
            int[] randInput = new int[20];
            string[] arrayRecupInterger;
            int[] arrayFinalInteger;
            string userInput;
            bool errorFormat;
            Console.WriteLine("Souhaitez-vous entrer jusqu'à 20 entiers séparés par le caractère '_' ? ('OUI' pour valider, sinon le tableau sera aléatoire)");
            userQuestion = Console.ReadLine().ToLower();
            if (userQuestion.Equals("oui"))
            {
                do
                {
                    errorFormat = false;
                    Console.WriteLine("Combien de nombres à entrer ?");
                    userArraySize = int.Parse(Console.ReadLine());
                    Console.WriteLine($"veuillez entrer {userArraySize} nombres");
                    userInput = Console.ReadLine();
                    arrayRecupInterger = new string[userArraySize];
                    arrayRecupInterger = userInput.Split('_');

                    foreach (string value in arrayRecupInterger)
                    {
                        if (!int.TryParse(value, out _))
                        {
                            errorFormat = true;
                        }
                    }
                    arrayFinalInteger = new int[userArraySize];

                    for (int i = 0; i < arrayRecupInterger.Length; i++)
                    {
                        arrayFinalInteger[i] = int.Parse(arrayRecupInterger[i]);
                    }

                } while (errorFormat);
                Console.WriteLine($"vous avez saisi {userArraySize} valeurs");
                AverageArray(arrayFinalInteger);
                IntegerSort(arrayFinalInteger);

            }
            else
            {
                int nbrValueArray;
                for (int k = 0; k < randInput.Length; k++)
                {
                    nbrValueArray = rand.Next(-50, 51);
                    randInput[k] = nbrValueArray;
                }

                AverageArray(randInput);
                IntegerSort(randInput);
            }
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
