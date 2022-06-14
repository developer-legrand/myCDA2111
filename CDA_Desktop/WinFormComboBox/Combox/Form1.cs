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
            if (cbxDataMain.SelectedIndex > -1)
            {
                lstDataSource.Add(cbxDataSource[cbxDataMain.SelectedIndex]);
                cbxDataSource.RemoveAt(cbxDataMain.SelectedIndex);
                lstDataTarget.DataSource = null;
                lstDataTarget.DataSource = lstDataSource;
                cbxDataMain.DataSource = null;
                cbxDataMain.DataSource = cbxDataSource;
            }
            else MessageBox.Show("le tableau est vide");
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            if (lstDataTarget.SelectedIndex > -1)
            {
                cbxDataSource.Add(lstDataSource[lstDataTarget.SelectedIndex]);
                lstDataSource.RemoveAt(lstDataTarget.SelectedIndex);
                lstDataTarget.DataSource = null;
                lstDataTarget.DataSource = lstDataSource;
                cbxDataMain.DataSource = null;
                cbxDataMain.DataSource = cbxDataSource;
            }
            else MessageBox.Show("le tableau est vide");
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            while(cbxDataSource.Count > 0)
            {
                lstDataSource.Add(cbxDataSource[0]);
                cbxDataSource.RemoveAt(0);
                lstDataTarget.DataSource = null;
                lstDataTarget.DataSource = lstDataSource;
                cbxDataMain.DataSource = null;
                cbxDataMain.DataSource = cbxDataSource;
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            while (lstDataSource.Count > 0)
            {
                cbxDataSource.Add(lstDataSource[0]);
                lstDataSource.RemoveAt(0);
                lstDataTarget.DataSource = null;
                lstDataTarget.DataSource = lstDataSource;
                cbxDataMain.DataSource = null;
                cbxDataMain.DataSource = cbxDataSource;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            int index = lstDataTarget.SelectedIndex;
            int newIndex = index + 2;
            string item = lstDataSource[index];
            if (index < lstDataSource.Count()-1)
            {
                lstDataSource.Insert(newIndex, item);
                lstDataSource.RemoveAt(index);
                lstDataTarget.DataSource = null;
                lstDataTarget.DataSource = lstDataSource;
            }
            else MessageBox.Show("Out Of Range");
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int index = lstDataTarget.SelectedIndex;
            int newIndex = index - 2;
            string item = lstDataSource[index];
            lstDataSource.Insert(newIndex, item);
            /*lstDataSource.RemoveAt(index - 1);*/
            lstDataTarget.DataSource = null;
            lstDataTarget.DataSource = lstDataSource;
        }    
    }
}