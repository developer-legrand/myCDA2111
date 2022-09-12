using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternVisitor
{
    public class Figures : Figure
    {
        private List<Figure> sesFigures;

        public override void Accepter(IVisiteurDeFigure visiteurDeFigure)
        {
            visiteurDeFigure.Visiter(this);
            foreach (Figure f in sesFigures)
            {
                f.Accepter(visiteurDeFigure);
            }
        }
    }
}