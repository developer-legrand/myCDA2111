using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternComposite
{
    public class Addition : Binaire
    {

        public Addition(Expression op1, Expression op2) : base(op1, op2)
        {
            
        }


        public override string ToString()
        {
            return Evaluer().ToString();
        }

        public override string Formater()

        {
            return op1.Formater() + " + " + op2.Formater();
        }
        public override int Evaluer()
        {
            return op1.Evaluer() + op2.Evaluer();
        }
    }
}