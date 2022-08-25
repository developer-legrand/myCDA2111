using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression op1, Expression op2) : base(op1, op2)
        {

        }

        public override int Evaluer()
        {
            return op1.Evaluer() - op2.Evaluer();
        }

        public override string ToString()
        {
            return Evaluer().ToString();
        }

        public override  string Formater()
        {
            return (op1.Formater()) + " - " + (op2.Formater());
        }
    } 
}
