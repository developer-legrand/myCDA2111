using System;

namespace mois_naissance
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthMonth;
            string[] nameMonth = new string[] { "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "août", "septembre", "octobre", "novembre", "décembre" };
            string[] nMonth = new string[] { "premier", "deuxième", "troisième", "quatrième", "cinquième", "sixième", "septième", "huitième", "neuvième", "dixième", "onzième", "douzième" };
            string recupNameMonth = "";
            string recupNMonth = "";
            do
            {
                Console.WriteLine("veuillez entrer votre mois de naissance: ");
                birthMonth = int.Parse(Console.ReadLine());
                if (birthMonth < 1 | birthMonth > 12)
                {
                    Console.WriteLine("erreur de sasie veuillez recommencer");
                }
            } while (birthMonth < 1 | birthMonth > 12);

            for (int i = 0; i < nameMonth.Length; i++)
            {
                recupNameMonth = nameMonth[birthMonth - 1];

            }
            for (int j = 0; j < nMonth.Length; j++)
            {
                recupNMonth = nMonth[birthMonth - 1];
            }

            Console.WriteLine($"{recupNameMonth} est le {recupNMonth} de l'année !");

        }
    }
}
