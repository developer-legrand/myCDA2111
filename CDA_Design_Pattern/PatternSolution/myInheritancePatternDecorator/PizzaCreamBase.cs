using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myInheritancePatternDecorator
{
    public class PizzaCreamBase : PizzaBase
    {
        private bool cream;

        public PizzaCreamBase()
        {
            throw new System.NotImplementedException();
        }

        public double Cost()
        {
            throw new System.NotImplementedException();
        }

        public string Description()
        {
            throw new System.NotImplementedException();
        }
    }
}