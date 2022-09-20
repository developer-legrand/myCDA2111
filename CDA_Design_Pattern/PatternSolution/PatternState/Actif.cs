using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternState
{
    public abstract class Actif : IEtatBouton
    {
        public abstract void disable();

        public abstract void display();

        public abstract void enable();

        public abstract void erase();

        public abstract void press();

        public abstract void release();
    }
}