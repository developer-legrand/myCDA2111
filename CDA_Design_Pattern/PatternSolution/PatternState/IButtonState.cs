using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternState
{
    public interface IEtatBouton
    {
        void display();
        void press();
        void release();
        void disable();
        void enable();
        void erase();
    }
}