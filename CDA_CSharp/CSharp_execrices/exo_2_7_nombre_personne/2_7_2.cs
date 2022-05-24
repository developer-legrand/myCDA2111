using System;

namespace exo_2_7_1_nombre_personne
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            const int userInputNameColumn = 0;
            const int userInputAgeColumn = 1;
            bool quit = true;
            int lengthTab = 1;
            string[,] arrayPerson = new string[lengthTab, 2];
            string[,] arrayTempPerson;
            int belowTwenty = 0;
            int aboveTwenty = 0;
            int equalTwenty = 0;

            do
            {
                Console.WriteLine("enter your name and your age separated with a space");
                string userInput = Console.ReadLine();
                string[] recupFormat = userInput.Split(" ");
                if (userInput == "quit")
                {
                    quit = false;
                }

                else
                {
                    foreach (string data in recupFormat)
                    {
                        int recup;
                        if (int.TryParse(data, out recup))
                        {
                            arrayPerson[row, userInputAgeColumn] = data;
                        }
                        else
                        {
                            arrayPerson[row, userInputNameColumn] = data;
                        }
                    }

                    arrayTempPerson = new string[arrayPerson.Length / 2 + 1, 2];
                    for (row = 0; row < arrayPerson.Length / 2; row++)
                    {
                        arrayTempPerson[row, userInputNameColumn] = arrayPerson[row, userInputNameColumn];
                        arrayTempPerson[row, userInputAgeColumn] = arrayPerson[row, userInputAgeColumn];
                    }
                    arrayPerson = arrayTempPerson;
                }
            }
            while (quit);
            for (row = 0; row < arrayPerson.Length / 2 - 1; row++)
            {
                Console.WriteLine($"My firstname is {arrayPerson[row, userInputNameColumn]} and i have {arrayPerson[row, userInputAgeColumn]} years old"); 
            }

            for (row = 0; row < arrayPerson.Length /2 -1; row++)
            {
                int myRecupAgeFormat = int.Parse(arrayPerson[row, userInputAgeColumn]);

                if (myRecupAgeFormat < 20)
                {
                    belowTwenty++;
                }
                else if (myRecupAgeFormat > 20)
                {
                    aboveTwenty++;
                }
                else
                {
                    equalTwenty++;
                }

            }
            if (belowTwenty == 20)
            {
                Console.WriteLine("EVERYBODY IS LESS THAN 20");
            }
            else if (aboveTwenty == 20)
            {
                Console.WriteLine("EVERYBODY IS MORE THAN 20");
            }
            else
            {
                Console.WriteLine($"There are {belowTwenty} young people\nthere are {aboveTwenty} old people\nThere are {equalTwenty} people who are 20");
            }


        }
    }
}
