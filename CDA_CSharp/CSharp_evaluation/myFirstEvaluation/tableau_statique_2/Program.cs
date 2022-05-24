using System;

namespace tableau_statique_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userArraySize;
            bool errorFormat;
            int size;

            do
            {
                Console.WriteLine("veuillez enter la taille de votre tableau désirée");
                userArraySize = Console.ReadLine();
                size = int.Parse(userArraySize);
                if (size < 1 | size > 20)
                {
                    Console.WriteLine("erreur de saisie, veuillez réessayer");
                }
            } while (size < 1 | size > 20);


            do
            {
                errorFormat = false;
                Console.WriteLine("écrivez un nombre d'entier de la taille désiré auparavant (séparé par un underscore)");
                userInput = Console.ReadLine();

                string[] arrayRecupInterger = new string[int.Parse(userArraySize)];
                arrayRecupInterger = userInput.Split('_');

                foreach (string value in arrayRecupInterger)
                {
                    if (!int.TryParse(value, out int format))
                    {
                        errorFormat = true;
                    }

                }

                string[] arrayFinalInteger = new string[int.Parse(userArraySize)];

                for (int index = 0; index < arrayFinalInteger.Length; index++)
                {
                    arrayFinalInteger[index] = arrayRecupInterger[index];
                }
                foreach (string value in arrayFinalInteger)
                {
                    Console.WriteLine(value);
                }

            } while (errorFormat);
        }

        public static void UserStaticArray(string _userInput, int _userArraySize)
        {
            string[] userArray = new string[_userArraySize];

            for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = _userInput;
            }
            for (int j = 0; j < userArray.Length; j++)
            {
                Console.WriteLine(userArray[j]);
            }

        }
    }
}


