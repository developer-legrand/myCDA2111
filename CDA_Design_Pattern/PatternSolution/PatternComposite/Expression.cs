using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternComposite
{
    
    public abstract class Expression
    {
        public abstract int Evaluer();
        public abstract string Formater();
    }
}