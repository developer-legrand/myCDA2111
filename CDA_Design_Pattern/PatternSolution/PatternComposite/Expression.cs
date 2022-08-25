using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternComposite
{
    
    public abstract class Expression
    {
        public object op1 { get; set; }
        public object op2 { get; set; }

        public abstract int Evaluer();
        public abstract string Formater();
    }
}