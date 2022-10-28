using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openClassroomTest
{
    internal class Lettre
    {
        /*public static int CompteMots(string phrase)
        {
            return 0;
        }*/


        //-----------------------------------------------------------------------------------
        /*public static int NombreMots(string phrase)
        {
            return phrase.Length == 0 ? 0 : 1;
        }*/


        //-----------------------------------------------------------------------------------
        /*public static int CompteMots(string phrase)
        {
            if (phrase.Length == 0)
                return 0;
            int cpt = 0;
            foreach (var caractere in phrase)
            {
                if (caractere == ' ')
                    cpt++;
            }
            return cpt + 1;
        }*/


        //-----------------------------------------------------------------------------------
        /*public static int CompteMots(string phrase)
        {
            if (phrase.Length == 0)
                return 0;
            return phrase.Count(caractere => caractere == ' ') + 1;
        }*/


        //-----------------------------------------------------------------------------------

        /*public static int CompteMots(string phrase)
        {
            if (phrase.Length == 0)
                return 0;

            var mots = phrase.Split(' ');
            int cpt = 0;
            foreach (var mot in mots)
            {
                if (mot.Trim().Length > 0)
                    cpt++;
            }
            return cpt;
        }*/

        public static int CompteMots(string phrase)
        {
            var mots = phrase.Split(' ');
            return mots.Count(mot => mot.Length > 0);
        }
    }
}
