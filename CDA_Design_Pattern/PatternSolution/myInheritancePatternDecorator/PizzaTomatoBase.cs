using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myInheritancePatternDecorator
{
    public class PizzaTomatoBase : PizzaBase
    {

        private bool tomato;

        public PizzaTomatoBase()
        {
            throw new System.NotImplementedException();
        }

        public double Cost()
        {
            throw new System.NotImplementedException();
        }

        public string Description()
        {
            throw new System.NotImplementedException();
        }
    }
}