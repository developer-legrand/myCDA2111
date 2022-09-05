using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myInheritancePatternDecorator
{
    public class PizzaCreamBase : Pizza
    {
        public bool cream;

        public PizzaCreamBase()
        {
            throw new System.NotImplementedException();
        }

        public override double Cost()
        {
            if (cream)
                return 12;
            else return 0;
        }

        public override string Description()
        {
            return "pizza base crème".ToString();
        }
    }
}