using System;
using System.Text;
namespace tableau_statique_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOnLine = new string[3] { "marie", "livia", "daniel" };
            AlignArray(arrayOnLine);
        }


        public static void AlignArray(string[] _alignArray)
        {

            string myAlignString;
            StringBuilder myAlignContent = new StringBuilder();
            for (int index = 0; index < _alignArray.Length; index++)
            {
                myAlignContent.Append(_alignArray[index] + " - ");
            }

            myAlignString = myAlignContent.ToString() + " la longueur du tableau est de : " + _alignArray.Length;
            Console.WriteLine(myAlignString);

        }
    }
}
