namespace Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnHardDisk_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) { return; }
            tvHardDisk.Nodes.Add(SelectDirectory(dialog.SelectedPath));
        }
        private TreeNode SelectDirectory(string path)
        {
            TreeNode result = new TreeNode(path);
            foreach (var subdirectory in Directory.GetDirectories(path))
            {
                result.Nodes.Add(SelectDirectory(subdirectory));
            }
            return result;
        }
        private void BtnExpansion_Click(object sender, EventArgs e)
        {
            tvHardDisk.ExpandAll();
        }
        private void BtnReduction_Click(object sender, EventArgs e)
        {
            tvHardDisk.CollapseAll();
        }
        private void TbPath_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tvHardDisk.Nodes.Add(SelectDirectory(tbPath.Text));
        }
    }
}