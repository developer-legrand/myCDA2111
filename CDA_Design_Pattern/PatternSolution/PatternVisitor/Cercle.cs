using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternVisitor
{
    public class Cercle : Figure
    {
        private double rayon;
        public void Accepter(IVisiteurDeFigure visiteurDeFigure)
        {
            visiteurDeFigure.Visit(this);
        }
    }
}