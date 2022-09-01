using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPatternDecorator.ConcreteDecorator
{
    internal class Salmon : BaseDecorator.ElementDecorator
    {
        public Salmon(IElementPizza elementToDecorate)
        {
            this.elementToDecorate = elementToDecorate;
        }
        public override string Description => elementToDecorate.Description + " - Salmon";
        public override double Price => 2 + elementToDecorate.Price;
    }
}
