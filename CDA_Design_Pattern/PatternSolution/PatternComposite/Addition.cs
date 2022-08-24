using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternComposite
{
    public class Addition : Binaire
    {
        private List<Nombre> listeNombre;
        public Addition(Expression op1, Expression op2) : base(op1, op2)
        {
            
        }

        public override int Evaluer()
        {
            return op1.Evaluer() + op2.Evaluer();
        }

        public override string ToString()
        {
            return Evaluer().ToString();
        }

        public override string Formater()
        {
           foreach(Nombre nombre in listeNombre)
            {
                return 
            }
        }
    }
}