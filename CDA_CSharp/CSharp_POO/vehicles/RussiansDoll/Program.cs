using System;

namespace RussiansDoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Doll firstDoll = new (10, "pierre", null , null);
            Doll secondDoll = new (8, "paul", null, null);
            Doll thirdDoll = new (6, "jacques",null, null);

            /* thirdDoll.PlaceDollIn(secondDoll);
             secondDoll.Close();
             thirdDoll.Open();*/
            /* 
             thirdDoll.PlaceDollIn(firstDoll);
             secondDoll.PlaceDollIn(thirdDoll);
             secondDoll.PlaceDollIn(firstDoll);
             thirdDoll.PlaceDollIn(secondDoll);*/
 
            thirdDoll.PlaceDollIn(firstDoll);
            secondDoll.PlaceDollIn(firstDoll);
            thirdDoll.PlaceDollIn(firstDoll);

        }
    }
}
