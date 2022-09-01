using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPatternDecorator
{
    public interface IElementPizza
    {
        public string Description { get; }
        public double Price { get; }
    }
}