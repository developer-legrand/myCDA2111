using System;
using System.Text;
using System.Text.RegularExpressions;

namespace zTest
{
    class ztest
    {
        static void Main(string[] args)
        {

            /* bool quit = true;
             //-----------pangramme du juge blond
             do
             { 
                 string regexTest = "Portez ce vieux whisky au juge blond qui fume 0123456789#*";
                 Console.WriteLine(regexTest);
                 Console.WriteLine("veuillez entrer votre regex");
                 string myRegex = Console.ReadLine();
                 Regex recupRegex = new Regex(myRegex);

                 regexTest = recupRegex.Replace(regexTest, "");
                 Console.WriteLine(regexTest);
                 Console.WriteLine();
                 Console.WriteLine("do you want ton continue? (yes or no)");
                 string response = Console.ReadLine();
                 if (response == "no")
                 {
                     quit = false;
                 }
             }
             while (quit);
         }*/


            string alphaNumeric = "abcdefghijklnmopqrstuvwxyz0123456789";
            StringBuilder addTokenChar = new StringBuilder("", 15);
            Random rand = new Random();

            for (int i = 0; i < addTokenChar.Capacity - 1; i++)
            {
                int indexCharToAdd = rand.Next(0, alphaNumeric.Length - 1);
                char charToAdd = alphaNumeric[indexCharToAdd];
                charToAdd = CharToUpper(charToAdd);
                addTokenChar.Append(charToAdd);
            }

            string finalToken = "";
            finalToken = addTokenChar.ToString();
            Console.WriteLine($"votre token est :{finalToken}");

        }
        public static char CharToUpper(char _charOfMyBuilder)
        {
            if (Char.IsLetter(_charOfMyBuilder))
            {
                string uhu;
                Random randChar = new Random();
                int test = randChar.Next(0, 2);
                if (test == 1)
                {
                    uhu = _charOfMyBuilder.ToString().ToUpper();
                    return uhu[0];
                }
            }
            return _charOfMyBuilder;
            

        }

    }
}
