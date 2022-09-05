using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPatternDecorator.ConcreteComponent
{
    public class CreamBase : IElementPizza
    {
        public double Price { get; }
        public string Description { get; }

        public CreamBase()
        {
            Description = "Pizza Cream Base";
            Price = 9.00;
        }
    }
}