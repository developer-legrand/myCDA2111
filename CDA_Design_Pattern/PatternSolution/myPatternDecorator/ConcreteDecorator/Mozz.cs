using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPatternDecorator.ConcreteDecorator
{
    internal class Mozz : BaseDecorator.ElementDecorator
    {
        public Mozz(IElementPizza elementToDecorate)
        {
            this.elementToDecorate = elementToDecorate;
        }
        public override string Description => elementToDecorate.Description + " - Mozz";
        public override double Price => .50 + elementToDecorate.Price;
    }
}
