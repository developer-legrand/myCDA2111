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

        ViewBoxManager viewBox;

        public frmToutEmbal()
        {
            InitializeComponent();
        }

        private void frmToutEmbal_Load(object sender, EventArgs e)
        {
            prodA = new Production("A", 1000, 10000);
            prodB = new Production("B", 5000, 25000);
            prodC = new Production("C", 10000, 120000);    
            prodA.ProdValueChanged += ProdUpdated;

            viewBox = new ViewBoxManager();
            viewBox.setProduction(prodA);

            pageA.Controls.Add(viewBox);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodA.StartProduction();
        }

        private void ProdUpdated(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prodSender)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    progressBarProdA.Value = prodSender.BoxProduced;
                }));
            }
        }

    }
}