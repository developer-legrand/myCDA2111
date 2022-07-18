using Event.EventLib;

namespace Event
{
    public partial class EventTreeView : Form
    {
        private FolderBrowserDialog dialog;
        public EventTreeView()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timerClock.Start();
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }
        private void BtnHardDisk_Click(object sender, EventArgs e)
        {
            TreeManager.DisplayTreeNode(dialog, tvHardDisk, tbPath);
        }
        private void TbPath_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TreeManager.InputDirectory(tbPath, tvHardDisk);
        }
        private void BtnExpansion_Click(object sender, EventArgs e)
        {  
            tvHardDisk.BeginUpdate();
            tvHardDisk.ExpandAll();
            tvHardDisk.EndUpdate();
        }

        private void BtnReduction_Click(object sender, EventArgs e)
        {
            tvHardDisk.BeginUpdate();
            tvHardDisk.CollapseAll();
            tvHardDisk.EndUpdate();
        }
    }
}