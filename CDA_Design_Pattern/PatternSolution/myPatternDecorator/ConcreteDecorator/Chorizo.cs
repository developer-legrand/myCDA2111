using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPatternDecorator.ConcreteDecorator
{
    internal class Chorizo : BaseDecorator.ElementDecorator
    {
        public Chorizo(IElementPizza elementToDecorate)
        {
            this.elementToDecorate = elementToDecorate;
        }
        public override string Description => elementToDecorate.Description + " - Chorizo";
        public override double Price => 1.00 + elementToDecorate.Price;
    }
}
