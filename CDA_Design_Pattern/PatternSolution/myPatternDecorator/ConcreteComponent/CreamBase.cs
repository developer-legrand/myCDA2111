using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myPatternDecorator.ConcreteComponent
{
    public class CreamBase : IElementPizza
    {


        private string description;

   
        public double Price { get; }
        public string Description { get => description; /*set => description = value;*/ }

        public CreamBase()
        {
            description = "Pizza Cream Base";
            Price = 9.00;
        }


        
    }
}