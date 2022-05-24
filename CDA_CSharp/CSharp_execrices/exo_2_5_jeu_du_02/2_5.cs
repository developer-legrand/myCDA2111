using System;

namespace exo_2_5_jeu_du_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int computerInput;
            int userInput;
            int[] computerPoint = new int[10];
            int[] userPoint = new int[10];
            int scoredPoint = 1;
            int victoryPoint = 10;
            int computerScore = 0;
            int userScore = 0;
            int indexComputer = 0;
            int indexUser = 0;

            for (int index = 0;index < computerPoint.Length; index++)
            {
                computerPoint[index] = scoredPoint;
                scoredPoint++;
                Console.WriteLine(computerPoint[index]);
            }

            scoredPoint = 1;

            for (int index = 0; index < userPoint.Length; index++)
            {
                userPoint[index] = scoredPoint;
                scoredPoint++;
            }

            do
            {
                computerInput = rand.Next(0, 2);
                Console.WriteLine("input a number 0,1 or 2");
                userInput = int.Parse(Console.ReadLine());
                if ((userInput < 0) | (userInput > 2))
                {
                    Console.WriteLine("input error, please enter a new number 0,1 or 2");
                    userInput = int.Parse(Console.ReadLine());
                }

                if (computerInput - userInput == 2)
                {
                    computerScore = computerPoint[indexComputer];
                    indexComputer++;
                    Console.WriteLine($"SCORE: Computer {computerScore} - User {userScore}");
                }

                if (userInput - computerInput == 2)
                {
                    userScore = userPoint[indexUser];
                    indexUser++;
                    Console.WriteLine($"Computer choose: {computerInput} and  User choose: {userInput}");
                    Console.WriteLine($"SCORE: Computer {computerScore} - User {userScore}");
                }

                if (computerInput - userInput == 1)
                {
                    userScore = userPoint[indexUser];
                    indexUser++;
                    Console.WriteLine($"Computer choose: {computerInput} and  User choose: {userInput}");
                    Console.WriteLine($"SCORE: Computer {computerScore} - User {userScore}");
                }

                if (userInput - computerInput == 1)
                {
                    computerScore = computerPoint[indexComputer];
                    indexComputer++;
                    Console.WriteLine($"Computer choose: {computerInput} and  User choose: {userInput}");
                    Console.WriteLine($"SCORE: Computer {computerScore} - User {userScore}");
                }

                else /*if((userInput - computerInput == 0))*/
                {
                    Console.WriteLine("draw! try again");
                    Console.WriteLine($"Computer choose: {computerInput} and  User choose: {userInput}");
                    Console.WriteLine($"SCORE: Computer {computerScore} - User {userScore}");
                }


            } while (userScore < victoryPoint & computerScore < victoryPoint);
            
            if (userScore == 10)
            {
                Console.WriteLine("You win");
                Console.WriteLine($"SCORE: Computer {computerScore} - User {userScore}");
            }else
            {
                Console.WriteLine("You lose");
                Console.WriteLine($"SCORE: Computer {computerScore} - User {userScore}");
            }
        }
    }
}
