using WinFormToutEmbal.LibToutEmbal;

namespace WinFormToutEmbal
{
    public partial class frmToutEmbal : Form
    {
        private Production prodA;
        private Production prodB;
        private Production prodC;
        private Thread threadA;
        public frmToutEmbal()
        {
            InitializeComponent();
        }

        private void frmToutEmbal_Load(object sender, EventArgs e)
        {
            prodA = new Production("A", 1000, 10000);
            prodB = new Production("B", 5000, 25000);
            prodC = new Production("C", 10000, 120000);
        }
    }
}