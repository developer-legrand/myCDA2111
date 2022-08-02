using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormToutEmbal.LibToutEmbal
{
    public class ViewControlProduction
    {
        private object sender;
        private Production prod;


        public ViewControlProduction ()
        {
            this.sender = sender;
            this.prod = prod;
            sender.Tag = prod.TypeProduction;
        }


    }
}
