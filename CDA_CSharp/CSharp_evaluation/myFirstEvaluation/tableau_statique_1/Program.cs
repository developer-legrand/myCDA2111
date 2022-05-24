using System;

namespace tableau_statique_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questionArray = new string[6];
            string[] answerArray = new string[6];
            string userAnswer = "";
            string userquestion = "";

            questionArray[0] = "l'évaluation est elle réussie?";
            questionArray[1] = "est ce que animal crossing est un bon jeu?";
            questionArray[2] = "le feu brûle t il?";
            questionArray[3] = "du coup, l'eau mouille t elle ?";
            questionArray[4] = "la terre est elle plate ?";
            questionArray[5] = "est ce que ce questionnaire est constructif ? :)";
            Console.WriteLine("veuillez répondre par 'vrai' ou 'faux' au fabuleux questionnaire suivant");
            for (int i = 0; i < questionArray.Length; i++)
            {
                userquestion = questionArray[i];
                Console.WriteLine(userquestion);
                userAnswer = Console.ReadLine();
                if (userAnswer != "vrai" && userAnswer != "faux")
                {
                    i--;
                }
                answerArray[i] = userAnswer;
            }

            for (int j = 0; j < questionArray.Length; j++)
            {
                Console.WriteLine($"{questionArray[j]} vous avez répondu: {answerArray[j]}");
            }

        }
    }
}

