namespace Combox
{
    public partial class Combox : Form
    {

        List<string> cbxDataSource;
        List<string> lstDataSource;

        public Combox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxDataSource = new List<string>() {"Belgique", "Allemagne", "Portugal", "Espagne", "Grèce"};
            lstDataSource = new List<string>();
            cbxDataMain.DataSource = cbxDataSource;
            lstDataTarget.DataSource = lstDataSource;
            btnRemoveAll.Enabled = false;
            btnRemoveOne.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
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
                if (cbxDataSource.Count == 0)
                {
                    btnSelectAll.Enabled = false;
                    btnSelectOne.Enabled = false;
                }
                if (lstDataSource.Count != 0)
                {
                    btnRemoveOne.Enabled = true;
                    btnRemoveAll.Enabled = true;
                    btnUp.Enabled = true;
                    btnDown.Enabled = true;
                }
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
                if (lstDataSource.Count == 0)
                {
                    btnRemoveAll.Enabled = false;
                    btnRemoveOne.Enabled = false;
                    btnDown.Enabled = false;
                    btnUp.Enabled = false;
                }
                if (cbxDataSource.Count != 0)
                {
                    btnSelectAll.Enabled = true;
                    btnSelectOne.Enabled = true;
                }
            }
            else MessageBox.Show("veuillez sélectionner un élément");
          
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
        
            btnSelectAll.Enabled = false;
            btnSelectOne.Enabled = false;
            btnRemoveAll.Enabled = true;
            btnRemoveOne.Enabled = true;
            btnDown.Enabled = true;
            btnUp.Enabled = true;   
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
            btnSelectAll.Enabled = true;
            btnSelectOne.Enabled = true;
            btnRemoveAll.Enabled = false;
            btnRemoveOne.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
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
            int newIndex = index - 1;
            string item = lstDataSource[index];
            if (index > 0)
            {    
                lstDataSource.Insert(newIndex, item);
                lstDataSource.RemoveAt(index + 1);
                lstDataTarget.DataSource = null;
                lstDataTarget.DataSource = lstDataSource;
            }
            else MessageBox.Show("Out Of Range"); 
        }    
    }
}