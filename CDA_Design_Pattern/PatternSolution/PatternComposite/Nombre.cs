using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternComposite
{
    public class Nombre : Expression
    {
        private int valeur;
      
        public Nombre(int valeur)
        {
            this.valeur = valeur;
        }

        public override int Evaluer()
        {
            return valeur;
        }

        public override string ToString()
        {
            return valeur.ToString();
        }

        public override string Formater()
        {
             return valeur.ToString() + "uhu";
        }
    }
}