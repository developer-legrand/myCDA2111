using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPatternDecorator
{
    public interface IElementPizza
    {
        public abstract string Description { get; }
        public abstract double Price { get; }
    }
}