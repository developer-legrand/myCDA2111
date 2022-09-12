using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternVisitor
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public override void Accepter(IVisiteurDeFigure visiteurDeFigure)
        {
            visiteurDeFigure.Visiter(this);
        }
    }
}