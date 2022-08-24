using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternComposite
{
    public abstract class Binaire : Expression 
    {
        public Expression op1;
        public Expression op2;

        public Binaire(Expression op1, Expression op2)
        {
            this.op1 = op1;
            this.op2 = op2;
        }
    }
}