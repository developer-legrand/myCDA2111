using System.Collections;
using System.Text.RegularExpressions;

namespace Element
{
    public partial class Element : Form
    {
        string pattern;
        string resultIndex;
        string resultName;
        ErrorProvider errorProvider;
        Regex rgInputUser;
        int lstBoxLength;
        int index;
        bool inputUserBool;

        public Element()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pattern = @"^[a-zA-Z]+[-]?[a-zA-Z]+$";
            rgInputUser = new Regex(pattern);
            errorProvider = new ErrorProvider();
        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
      
            resultName = isInputUserValid(tbInputUser.Text);
            if(resultName.Equals("EMPTY"))
            {
                errorProvider.SetError(tbInputUser, "le champs ne peut être vide");
                /* MessageBox.Show(errorProvider.GetError(tbInputUser));*/
                tbInputUser.Focus();
            }
            else if(resultName.Equals("FORMAT"))
            {
                errorProvider.SetError(tbInputUser, "seul les caractères alphabétiques, \"-\"  sont acceptés");
                /*MessageBox.Show(errorProvider.GetError(tbInputUser));*/
                tbInputUser.Focus();
                tbInputUser.Text = String.Empty;
            }
            else
            {
                lstBoxElement.Items.Add(tbInputUser.Text);
                tbInputUser.Text = String.Empty;
                tbInputUser.Focus();
                tbItemCount.Text = lstBoxElement.Items.Count.ToString();
                errorProvider.SetError(tbInputUser, String.Empty);
            }   
        }
        private void btnVider_Click(object sender, EventArgs e)
        {
            lstBoxElement.Items.Clear();
            tbName.Text = String.Empty;
            tbItemCount.Text = String.Empty;
            tbSelectedIndex.Text = String.Empty;
            tbIndexElement.Text = String.Empty;
            tbInputUser.Focus();
        }
        private void lstBoxElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbName.Text = lstBoxElement.SelectedItem.ToString();
            tbSelectedIndex.Text = lstBoxElement.SelectedIndex.ToString();
            MessageBox.Show(lstBoxElement.SelectedIndex.ToString());
        }
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            resultIndex = isIndexElementValid(tbIndexElement.Text);
            if(resultIndex.Equals("EMPTY"))
            {
                errorProvider.SetError(btnSelectionner, "le champs ne peut être vide");
            }
            else if(resultIndex.Equals("FORMAT"))
            {
                errorProvider.SetError(btnSelectionner, "seul les entiers sont acceptés");
                tbIndexElement.Text = String.Empty;
            }
            else if (resultIndex.Equals("NOEXIST"))
            {
                errorProvider.SetError(btnSelectionner, "l'index n'existe pas");
                tbIndexElement.Text = String.Empty;
            }
            else
            {
                index = int.Parse(tbIndexElement.Text);
                tbName.Text = lstBoxElement.Items[index].ToString();
                tbSelectedIndex.Text = tbIndexElement.Text.ToString();
            }
        }
        private string isInputUserValid(string _inputUser)
        {
            if(_inputUser == String.Empty)
            {
                return "EMPTY";
            }
            if(!rgInputUser.IsMatch(_inputUser))
            {
                return "FORMAT";
            }
            else
            {
                return "VALID";
            }    
        }

        private string isIndexElementValid(string _inputUser)
        {
            
            lstBoxLength = lstBoxElement.Items.Count;
            inputUserBool = int.TryParse(_inputUser, out _); 
            if (_inputUser == String.Empty)
            {
                return "EMPTY";
            }    
            if(!inputUserBool)
            {
                return "FORMAT";
            }
            index = int.Parse(_inputUser);
            if (index > (lstBoxLength -1))
            {
                return "NOEXIST";
            }
            else
            {
                return "VALID";
            }     
        }
    }
}