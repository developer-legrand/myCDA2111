using System;

namespace exo_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string extractUnit = "";
            string  extractTemperature = "";
            double finalTemperature;
            string saisie;
            const double minTemperature = -459.67;
            const double maxTemperature = 5000000;
            bool quit;
          

            do {
                extractUnit = "";
                extractTemperature = "";
                quit = true;
                Console.WriteLine("Saisir une température avec son unité de mesure (C ou F) :");
                saisie = Console.ReadLine().ToUpper();

                if (saisie.Equals("quit"))
                {
                    quit = false;
                }

                //------ EXTRACT TEMPERATURE FROM STRING --------

                for (int i = 0; i < saisie.Length; i++)
                {
                    if (Char.IsDigit(saisie[i]) || saisie[i].Equals(',') || saisie[i].Equals('-'))
                    {
                        extractTemperature += saisie[i];
                    }
                }

                finalTemperature = double.Parse(extractTemperature);

                // ----- EXTRACT UNIT FROM STRING

                for (int i = 0; i < saisie.Length; i++)
                {
                    if (Char.IsLetter(saisie[i]))
                    {
                        extractUnit += saisie[i];
                    }
                }

                if (extractUnit.Equals("F") || extractUnit.Equals("C"))
                {
                    if (finalTemperature < minTemperature || finalTemperature > maxTemperature)
                    {
                        Console.WriteLine("Erreur de saisie de données, veuillez saisir à nouveau");
                    }
                    else
                    { 
                        Console.WriteLine($"saisie de données : {finalTemperature}°{extractUnit}");
                        GoConvert(finalTemperature, extractUnit);
                    }
                }
                else
                {
                    Console.WriteLine("Erreur de saisie de données, veuillez saisir à nouveau");
                }
            
            } while (quit);
        }

        private static void GoConvert(double _finalTemperature, string _extractUnit)
        {
            double temperature = _finalTemperature;
            double convertTemperature;
            string unit = _extractUnit;

            //---------- Formule °C vers °F :
            //---------  °F = (X * 9/5) + 32

            //---------- Formule °F vers °C :
            //---------  °C = (X − 32) * 5/9

            if (unit.Equals("C"))
            {
                convertTemperature = (temperature * (9D / 5D)) + 32D;
                double roundConvertTemperature = Math.Round(convertTemperature, 3);
                Console.WriteLine($"{temperature} °{unit} correspond à : {roundConvertTemperature} °F");
            } else
            { 
                convertTemperature = (temperature - 32D) * 5D / 9D;
                double roundConvertTemperature = Math.Round(convertTemperature, 3);
                Console.WriteLine($"{temperature} °{unit} correspond à : {roundConvertTemperature} °C");
            }
          
        }

    }
}
