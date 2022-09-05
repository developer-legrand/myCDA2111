         using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPatternDecorator.ConcreteDecorator
{
    public class Anchovy : BaseDecorator.ElementDecorator
    {
        public Anchovy(IElementPizza elementToDecorate)
        {
            this.elementToDecorate = elementToDecorate;
        }
        public override string Description => elementToDecorate.Description + " - Anchovy";
        public override double Price => 0.70 + elementToDecorate.Price;
    }
}