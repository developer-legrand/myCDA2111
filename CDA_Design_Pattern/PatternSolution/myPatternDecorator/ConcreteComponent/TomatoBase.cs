using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPatternDecorator.ConcreteComponent
{
    public class TomatoBase : IElementPizza
    {
        public string Description { get; }
        public double Price { get; }

        public TomatoBase()
        {
            Description = "Pizza Tomato Base";
            Price = 8.00;
        }
    }
}