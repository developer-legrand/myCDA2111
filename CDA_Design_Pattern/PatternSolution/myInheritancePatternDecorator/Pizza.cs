using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myInheritancePatternDecorator
{
    public abstract class Pizza
    {
        public bool ham;
        public bool olive;
        public bool swisscheese;
        public bool mozz;
        public bool egg;
        public bool chorizo;
        public bool anchovy;
        public bool pepper;


        public abstract string Description();
        public  double Cost()
        {
            return 0.00;
        }

        public void addAnchovy()
        {
            throw new System.NotImplementedException();
        }

        public void addChorizo()
        {
            throw new System.NotImplementedException();
        }

        public void addEgg()
        {
            throw new System.NotImplementedException();
        }
    }
}