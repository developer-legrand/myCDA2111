using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternVisitor
{
    public abstract class Figure 
    {
        private int x;
        private int y;

        public abstract void Accepter(IVisiteurDeFigure visiteurDeFigure);
    }
}