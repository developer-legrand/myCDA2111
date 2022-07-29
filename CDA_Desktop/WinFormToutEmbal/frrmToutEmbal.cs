using System.ComponentModel;
using WinFormToutEmbal.LibToutEmbal;
using WinFormToutEmbal.UserControlTool;

namespace WinFormToutEmbal
{
    public partial class frmToutEmbal : Form
    {
        private Production prodA;
        private Production prodB;
        private Production prodC;
        private Thread threadA;

        ViewBoxUserControl viewBoxA;
        ViewBoxUserControl viewBoxB;
        ViewBoxUserControl viewBoxC;

        private int boxProduced;
        private int defectiveBoxPerHour;
        private int rateDefectiveBoxPerHour;
        private int rateDefectiveBoxFromStart;

        public frmToutEmbal()
        {
            InitializeComponent();
        }

        private void frmToutEmbal_Load(object sender, EventArgs e)
        {
            prodA = new Production("A", 1000, 10000);
            prodB = new Production("B", 5000, 25000);
            prodC = new Production("C", 10000, 120000); 
            
            viewBoxA = new ViewBoxUserControl();
            pageA.Controls.Add(viewBoxA);
            viewBoxB = new ViewBoxUserControl();
            pageB.Controls.Add(viewBoxB);
            viewBoxC = new ViewBoxUserControl();
            pageC.Controls.Add(viewBoxC);
/*
            prodA.ProdValueChanged += ProdUpdatedA;
            prodB.ProdValueChanged += ProdUpdatedB;*/
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodA.StartProduction();
        }


        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodB.StartProduction();
        }

  /*      private void ProdUpdatedA(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prodSender)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    progressBarProdA.Value = prodSender.BoxProduced;
                    viewBoxA.ViewBoxManagerValues(prodA);
                }));
            }
        }

        private void ProdUpdatedB(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prodSender)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    progressBarProdB.Value = prodSender.BoxProduced;
                    viewBoxB.ViewBoxManagerValues(prodB);
                }));
            }
        }*/

    }
}