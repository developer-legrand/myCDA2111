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

        public ViewControlProduction (object _sender, Production _prod)
        {
            this.sender = _sender;
            this.prod = _prod;
        }


        private void test()
        {
            if (sender is ToolStripMenuItem tsmItem)
            {
                if(tsmItem.GetCurrentParent().AreEq)
                {

                }
            }
        }

    }
}
