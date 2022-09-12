using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternVisitor
{
    public class Rectangle : Figure
    {
        private double longueur;
        private double largeur;

        public override void Accepter(IVisiteurDeFigure visiteurDeFigure)
        {
            visiteurDeFigure.Visiter(this);
        }
    }

 
}