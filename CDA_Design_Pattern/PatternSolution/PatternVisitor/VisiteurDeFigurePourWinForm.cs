using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternVisitor
{
    public abstract class VisiteurDeFigurePourWinForm
    {
        public abstract void Visiter(Rectangle rectangle);

        public abstract void Visiter(Cercle cercle);

        public abstract void Visiter(Triangle triangle);

        public abstract void Visiter(Figures figures);
    }
}