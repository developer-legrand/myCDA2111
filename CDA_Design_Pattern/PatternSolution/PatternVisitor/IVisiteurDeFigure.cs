using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternVisitor
{
    public interface IVisiteurDeFigure
    {
        void Visiter(Rectangle rectangle);
        void Visiter(Cercle cercle);
        void Visiter(Triangle triangle);
        void Visiter(Figures figures);
    }
}