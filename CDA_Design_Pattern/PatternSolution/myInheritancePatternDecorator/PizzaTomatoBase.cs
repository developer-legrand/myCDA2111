using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myInheritancePatternDecorator
{
    public class PizzaTomatoBase : Pizza
    {

        private bool tomato;

        public PizzaTomatoBase()
        {
            this.tomato = true;
            this.anchovy = true;

        }

        public override double Cost()
        {
            double pizzaCost = 0;
            if (tomato)
            {
                pizzaCost += 12;
                if (anchovy)
                {
                    pizzaCost += 1;
                }
            }

            else return pizzaCost;
        }

        public override string Description()
        {
            return "pizza base tomate";
        }
    }
}