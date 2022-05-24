using System;

namespace exo_2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string extractUnit;
            int temperatureOne;
            int temperatureTwo;
        
            do
            {
                Console.WriteLine("entrer your unit temperature");
                extractUnit = Console.ReadLine().ToUpper();
                Console.WriteLine("entrer your first temperature");
                temperatureOne = int.Parse(Console.ReadLine());
                Console.WriteLine("entrer your second temperature (data have to be higher than first");
                temperatureTwo = int.Parse(Console.ReadLine());

            } while (temperatureOne > temperatureTwo);

            int lengthArray = (temperatureTwo - temperatureOne) + 1;
            int[] temperatureArray = new int[lengthArray];

            for (int index = 0; index < temperatureArray.Length; index++)
            {
                temperatureArray[index] = temperatureOne;
                temperatureOne++;
            }

            GoConvert(temperatureArray, extractUnit);

        }
        private static void GoConvert(int[] _temperatureArray,string _extractUnit)
        {
            double convertTemperature;

            foreach (int _temperature in _temperatureArray)
            { 
                if (_extractUnit.Equals("C"))
                {
                    convertTemperature = (_temperature * (9D / 5D)) + 32D;
                    double roundConvertTemperature = Math.Round(convertTemperature, 2);
                    Console.WriteLine($"{_temperature} °{_extractUnit} correspond à : {roundConvertTemperature} °F");
                }
                else
                {
                    convertTemperature = (_temperature - 32D) * 5D / 9D;
                    double roundConvertTemperature = Math.Round(convertTemperature, 2);
                    Console.WriteLine($"{_temperature} °{_extractUnit} correspond à : {roundConvertTemperature} °C");
                }
            }
        }


    }
}
