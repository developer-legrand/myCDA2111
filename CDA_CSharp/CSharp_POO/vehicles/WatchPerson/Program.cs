using System;

namespace WatchPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new("paul");
            Person secondPerson = new("michael");
            Person thirdPerson = new("sophie");
            Person fourthPerson = new("franck");

            Watch festina = new(13, 30, "festina");
            Watch swatch = new(12, 30, "swatch");
            Watch casio = new(10, 30, "casio");
            Watch flikFlak = new(14, 30, "flik flak");

            firstPerson.PutWatch(festina);
            secondPerson.PutWatch(flikFlak);
            fourthPerson.PutWatch(casio);

            //Paul demande l'heure à Michaël.
            Console.WriteLine($"time is : {firstPerson.AskHourTo(secondPerson)}");

            //Paul demande l'heure à Michaël 15 minutes plus tard.
            for (int i = 1; i <= 50; i++)
            {
               flikFlak.AddTime();
            }
            Console.WriteLine($"time is : {firstPerson.AskHourTo(secondPerson)}");

            //Franck demande l'heure à Sophie qui n'a malheuresment pas de montre.
            Console.WriteLine($"{fourthPerson.AskHourTo(thirdPerson)}");

            //Mickaël retire sa montre et Paul lui demande à nouveau l'heure.
            secondPerson.RemoveWatch();
            Console.WriteLine($"{firstPerson.AskHourTo(secondPerson)}");

          /*Console.WriteLine($"{firstPerson.WatchWorn}");
            Console.WriteLine($"{thirdPerson.WatchWorn}");
            Console.WriteLine($"{festina.PersonGetThisWatch}");*/
        }
            
    }
}   

