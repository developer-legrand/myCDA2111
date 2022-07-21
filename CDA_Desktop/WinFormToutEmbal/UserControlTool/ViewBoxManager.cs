using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormToutEmbal.LibToutEmbal;

namespace WinFormToutEmbal.UserControlTool
{
    public partial class ViewBoxManager : UserControl
    {
        private Production prod;


        public ViewBoxManager()
        {
            InitializeComponent();
        }

        public void setProduction(Production p)
        {
            this.prod = p;
            tbNumberBox.Text = prod.BoxProduced.ToString();
        }
    }
}
