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
    public partial class ViewBoxUserControl : UserControl
    {
        private Production prod;

        private void ViewBoxManager_Load(object sender, EventArgs e)
        {
            tbNumberBox.Text = "0";
            tbNumberBox.ReadOnly = true;
            tbDefaultPerHour.Text = "0";
            tbDefaultPerHour.ReadOnly = true;
            tbDefaultFromStart.Text = "0";
            tbDefaultFromStart.ReadOnly = true;
        }

        public ViewBoxUserControl()
        {
            InitializeComponent();
        }


        public void ChangeProductionValues(Production p)
        {
            this.prod = p;
            tbNumberBox.Text = prod.BoxProduced.ToString();
            tbDefaultPerHour.Text = prod.RateDefectiveBoxPerHour.ToString();
            tbDefaultFromStart.Text = prod.RateDefectiveBoxFromStart.ToString();
        }
/*        private void ProdUpdatedA(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prodSender)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    progressBarProdA.Value = prodSender.BoxProduced;
                    viewBoxA.ViewBoxManagerValues(prodA);
                }));
            }
        }*/

    }
}
