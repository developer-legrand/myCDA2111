using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormToutEmbal.LibToutEmbal
{
    class ProdTypeManager
    {

        private Production Prod { get; set; }
        private TabPage Page { get; set; }
        private int boxProduced;
        public ProdTypeManager(Production prod)
        {
            Prod = prod;
            Page = page;
            //prod.T
        }

        public int GetNumberBox()
        {
            boxProduced = Prod.BoxProduced;
            return boxProduced;
        }
        public void GetDeficitBoxPerHour()
        {

        }
        public void GetDeficitBoxFromStart()
        {

        }

    }
}
