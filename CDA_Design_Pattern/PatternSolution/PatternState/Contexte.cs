using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternState
{
    public class AppuiBouton
    {
        private IEtatBouton etatDuBouton;

        public  void disable()
        {
            etatDuBouton.disable();
        }

        public  void display()
        {

        }

        public  void enable()
        {

        }

        public  void erase()
        {

        }

        public  void press()
        {

        }

        public  void release()
        {

        }

    }
}