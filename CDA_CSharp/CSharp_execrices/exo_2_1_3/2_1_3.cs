using System;
using System.Text.RegularExpressions;
using System.Text;

namespace exo_2_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"QUIT";
            StringBuilder formatInput = new StringBuilder();
            MatchCollection distance;
            MatchCollection unit;
        
            string finalResult;
            bool quitTest;
            bool exceptionTest;

            do
            {
                Console.WriteLine("veuillez entrer une distance en précisant son format sous la forme {distance}KM ou {distance}MI");

                formatInput.Append(Console.ReadLine().ToUpper() + ' ');

                exceptionTest = exceptionRegex.IsMatch(formatInput.ToString());

                quitTest = Regex.IsMatch(formatInput.ToString(), pattern);

            } while (!quitTest);

            finalResult = formatInput.ToString();

            distance = distanceRegex.Matches(finalResult);
            unit = unitRegex.Matches(finalResult);
           

            //------ match number element
                foreach (Match number in distance)
            {
                Console.WriteLine(int.Parse(number.Value));
            }
            //------- match format element
            
            foreach (Match format in unit)
            {
                Console.WriteLine(format.Value);
            }

        }

    }
}

