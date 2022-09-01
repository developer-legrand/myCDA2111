using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPatternDecorator.BaseDecorator
{
    public abstract class ElementDecorator : IElementPizza
    {
        protected IElementPizza elementToDecorate;
        public abstract string Description { get; }
        public abstract double Price { get; }
    }
}