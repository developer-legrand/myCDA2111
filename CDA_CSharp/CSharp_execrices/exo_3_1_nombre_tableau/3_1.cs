using System;

namespace exo_3_1_nombre_tableau
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random fillMysteriousArray = new Random();
            int[] mysteriousArray = new int[25];
            bool isDuplicated;
            int mysteriousNumberTemp;

            for (int i = 0; i < mysteriousArray.Length; i++)
            {
                do
                {
                    isDuplicated = false;
                    mysteriousNumberTemp = fillMysteriousArray.Next(1, 100);
                    for (int j = 0; j <= i; j++)
                    {
                        if (mysteriousArray[j] == mysteriousNumberTemp)
                        {
                           isDuplicated = true;
                        }
                    }
                    if(isDuplicated==false)
                    {
                        mysteriousArray[i] = mysteriousNumberTemp;
                    }
                } while (isDuplicated);
            }

           /* Console.WriteLine("-------------------Array before sort :");
            DisplayTab(mysteriousArray);
            Console.WriteLine("-------------------Array after sort :");*/
            BubbleSort(mysteriousArray);
           /* DisplayTab(mysteriousArray);*/

        }
        static void DisplayTab(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        public static void BubbleSort(int[] _mysteriousArray)
        {
            for (int i = 0; i < _mysteriousArray.Length -1; i++)
            { 
                for (int j = i + 1; j < _mysteriousArray.Length ; j++)
                {
                    if (_mysteriousArray[j] < _mysteriousArray[i])
                    {
                        int temp = _mysteriousArray[i];
                        _mysteriousArray[i] = _mysteriousArray[j];
                        _mysteriousArray[j] = temp;
                    }    
                }     
            }
        }
    }
}
