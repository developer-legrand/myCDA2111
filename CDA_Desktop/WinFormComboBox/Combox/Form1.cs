namespace Combox
{
    public partial class Form1 : Form
    {

        List<string> cbxDataSource;
        List<string> lstDataSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxDataSource = new List<string>() {"Belgique", "Allemagne", "Portugal", "Espagne", "Grèce"};
            lstDataSource = new List<string>();
            cbxDataMain.DataSource = cbxDataSource;
            lstDataTarget.DataSource = lstDataSource;
        }

        private void btnSelectOne_Click(object sender, EventArgs e)
        {
            if(cbxDataMain.SelectedIndex > -1)
            {
                lstDataSource.Add(cbxDataSource[cbxDataMain.SelectedIndex]);
                cbxDataSource.RemoveAt(cbxDataMain.SelectedIndex);
                lstDataSource = null;
                lstDataTarget.DataSource = lstDataSource;
                cbxDataSource = null;
                cbxDataMain.DataSource = cbxDataSource;
            }
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

    }
}