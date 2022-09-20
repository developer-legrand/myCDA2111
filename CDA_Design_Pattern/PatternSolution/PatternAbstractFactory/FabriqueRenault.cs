using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternAbstractFactory
{
    public abstract class FabriqueRenault : IFabriqueVehicule
    {
        private string marque;

        public void CreerVehicule()
        {
            throw new NotImplementedException();
        }
    }
}