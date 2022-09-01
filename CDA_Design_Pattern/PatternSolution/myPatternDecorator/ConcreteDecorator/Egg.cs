using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPatternDecorator.ConcreteDecorator
{
    public class Egg : BaseDecorator.ElementDecorator
    {
        public Egg(IElementPizza elementToDecorate)
        {
            this.elementToDecorate = elementToDecorate;
        }
        public override string Description => elementToDecorate.Description + " - Egg";
        public override double Price => .50 + elementToDecorate.Price;
    }
}