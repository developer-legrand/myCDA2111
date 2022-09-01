using myPatternDecorator.BaseDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPatternDecorator.ConcreteDecorator
{
    public class Olive : ElementDecorator
    {
        public Olive(IElementPizza elementToDecorate)
        {
            this.elementToDecorate = elementToDecorate;
        }
        public override string Description => elementToDecorate.Description + " - Olive";
        public override double Price => 1.00 + elementToDecorate.Price;
    }
}