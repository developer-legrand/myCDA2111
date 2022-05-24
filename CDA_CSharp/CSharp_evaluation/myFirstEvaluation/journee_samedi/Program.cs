using System;

namespace journee_samedi
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponseUtilisateur;
            string meteo;
            bool montagne = false;


            //--------------------SUPERMARCHE-----------------------------------------

            Console.WriteLine("veuillez répondre aux questions par oui par non");
            Console.WriteLine("vous partez faire vos courses, vos sacs sont ils vides ?");
            reponseUtilisateur = Console.ReadLine().ToLower();

            if (reponseUtilisateur.Equals("oui"))
            {
                Console.WriteLine("je prends ma lsite de courses et je vais au magasin à pied, étant à proximité");
            }
            else
            {
                Console.WriteLine("je vide mes sacs et je vais au magasin à pied");
            }

            Console.WriteLine("je remplis mon chariot avec des articles");
            Console.WriteLine("Avez vous biien rempli votre chariot avec toute votre liste?");
            reponseUtilisateur = Console.ReadLine().ToLower();

            if (reponseUtilisateur.Equals("oui"))
            {
                Console.WriteLine("je vais vers les caisses et je paie");
            }
            else
            {
                Console.WriteLine("je finis de remplir mon chariot avec des articles et je apsse en caisse");
            }

            Console.WriteLine("je rentre et je range mes achats");



            //------------------- SELON LE TEMPS --------------------
            Console.WriteLine("quel temps fait il pour savoir ce que vous voulez faire ? veuillez répondre par 'pluie', 'neige' ou 'soleil'");
            reponseUtilisateur = Console.ReadLine().ToLower();
            meteo = reponseUtilisateur;

            switch (meteo)
            {
                case "pluie":
                    Console.WriteLine("je reste à la maison, au programme : feu de cheminée, café ou thé chaud selon mon envie");
                    Console.WriteLine("votre connexion internet est elle stable ?");
                    reponseUtilisateur = Console.ReadLine().ToLower();
                    if (reponseUtilisateur.Equals("oui"))
                    {
                        Console.WriteLine("je vais pouvoir continuer a regardé ma série préférée");
                    }
                    else
                    {
                        Console.WriteLine("jelirai le deernier livre de mon auteur préféré");
                    }
                    break;

                case "soleil":
                    Console.WriteLine("je vais me promenerle long de la rivière");
                    Console.WriteLine("une fois sur place êtes voussuffisemment en forme et échauffer pour utiliser les installations sportives?");
                    reponseUtilisateur = Console.ReadLine().ToLower();
                    if (reponseUtilisateur.Equals("oui"))
                    {
                        Console.WriteLine("je profite des installations sportives");
                    }
                    else
                    {
                        Console.WriteLine("je ne suis pas prêt physqiuement, je vais observer la faune je rentrerai pour le repas de midi");
                    }
                    break;

                case "neige":
                    Console.WriteLine("a-t-il neigé la nuit dernière et la neige tient-elle toujours?");
                    reponseUtilisateur = Console.ReadLine().ToLower();
                    if (reponseUtilisateur.Equals("oui"))
                    {
                        Console.WriteLine("je décide d'aller à la montagne, je prend mes gants etc..");
                        montagne = true;
                    }
                    else
                    {
                        Console.WriteLine("je reste à la maison, au programme : feu de cheminée, café ou thé chaud selon mon envie");
                        Console.WriteLine("votre connexion internet est elle stable ?");
                        reponseUtilisateur = Console.ReadLine().ToLower();

                        if (reponseUtilisateur.Equals("oui"))
                        {
                            Console.WriteLine("je vais pouvoir continuer a regardé ma série préférée");
                        }

                        else
                        {
                            Console.WriteLine("je lirai le deernier livre de mon auteur préféré");
                        }
                    }
                    Console.WriteLine("la voiture était elle au garage ?");
                    reponseUtilisateur = Console.ReadLine().ToLower();
                    if (reponseUtilisateur.Equals("oui"))
                    {
                        Console.WriteLine("je prend la pelle pour déneiger et je pars à la montagne, je verrai sur place s'il me manque du matériel");
                    }

                    break;
            }

            //---------------REPAS DU MIDI---------------------------------------------
            Console.WriteLine("il est midi, il est temps de préparer à manger");

            if (montagne)
            {
                Console.WriteLine("je vais devoir manger au restaurant");
                do
                {
                    Console.WriteLine("y a t il de la place au restaurant");
                    reponseUtilisateur = Console.ReadLine().ToLower();
                    Console.WriteLine("refaite un tour de piste");
                } while (reponseUtilisateur.Equals("non"));

                Console.WriteLine("fini de manger, je retourne sur les piste en faisant attention à l heure et je finirai par rentrer");
                Console.WriteLine("je mangerai rapidement car trop fatigué");
            }
            else
            {
                Console.WriteLine("êtes vous motivé à cuisiner?");
                reponseUtilisateur = Console.ReadLine().ToLower();

                if (reponseUtilisateur.Equals("oui"))
                {
                    Console.WriteLine("je vais me préparer des petits pois avec une purée de carotte et un steak");
                }
                else
                {
                    Console.WriteLine("je vais me faire un sandwich");
                }
                Console.WriteLine("vos amis sont ils présents cette apres midi");
                reponseUtilisateur = Console.ReadLine().ToLower();

                if (reponseUtilisateur.Equals("oui"))
                {
                    Console.WriteLine("vos amis peuvent ils sortir cette apres midi?");
                    reponseUtilisateur = Console.ReadLine().ToLower();
                    if (reponseUtilisateur.Equals("oui"))
                    {
                        Console.WriteLine("je sortirai avec eux cette apres midi");
                        Console.WriteLine("nous finirons donc par manger au restaurant");
                    }

                    else
                    {
                        Console.WriteLine("je jouerai alors à WoW");
                        Console.WriteLine("j'ai trop joué je mnge sur le pouce");
                    }
                }
                else
                {
                    Console.WriteLine("je m'occuperai de mes plantes");
                    Console.WriteLine("c'est un festin ce soir car j'ai du temps pour cuisiner");
                }
            }
        }
    }
}
