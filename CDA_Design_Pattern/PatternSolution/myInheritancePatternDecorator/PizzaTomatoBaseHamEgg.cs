using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myInheritancePatternDecorator
{
    public class PizzaTomatoBaseHamEgg : PizzaTomatoBaseHam
    {
        private bool ham;
        private bool egg;

        public PizzaTomatoBaseHamEgg()
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