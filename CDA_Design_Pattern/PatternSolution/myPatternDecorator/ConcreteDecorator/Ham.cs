using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPatternDecorator.ConcreteDecorator
{
    internal class Ham : BaseDecorator.ElementDecorator
    {
        public Ham(IElementPizza elementToDecorate)
        {
            this.elementToDecorate = elementToDecorate;
        }
        public override string Description => elementToDecorate.Description + " - Ham";
        public override double Price => .50 + elementToDecorate.Price;
    }
}
