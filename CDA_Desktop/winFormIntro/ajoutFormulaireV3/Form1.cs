using System.Globalization;
using System.Text.RegularExpressions;

namespace ajoutFormulaireV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variables use on textBox
        private string nomPattern = @"^[a-zA-Z]+[-]?[a-zA-Z]+$";
        private string codePattern = @"^\d{5}$";
        private string nom;
        private float number;
        private string date;
        private string montant;
        private string montantFormat;
        private string code;
        

        private void TxTNomValidated(object sender, EventArgs e)
        {
            nom = txtNom.Text;
            if (String.IsNullOrEmpty(nom))
            {
                errorProvider.SetError(txtNom, "le nom ne peut être vide");
                txtNom.BackColor = Color.Red;
               
            } 
            else
            {
                if (Regex.IsMatch(nom, nomPattern))
                {
                    errorProvider.SetError(txtNom, "");
                    txtNom.BackColor = Color.Green;
                }
                else
                {
                    errorProvider.SetError(txtNom, "seul les caractères alphabétiques, \"-\"  sont acceptés");
                    txtNom.BackColor = Color.Red;
                }
            }
            
        }

        private void TxtDateValidated(object sender, EventArgs e)
        {
            date = txtDate.Text;
            DateTime convertDate;
            if (String.IsNullOrEmpty(date))
            {
                errorProvider.SetError(txtDate, "le nom ne peut être vide");
                txtDate.BackColor = Color.Red;

            }
            else
            {
                try
                {
                    convertDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    errorProvider.SetError(txtDate, "");
                    txtDate.BackColor = Color.Green;
                }
                catch
                {
                    errorProvider.SetError(txtDate, "la date doit être au format : JJ/MM/AAAA");
                    txtDate.BackColor = Color.Red;
                }
            }
       
        }

        private void TxtMontantValidated(object sender, EventArgs e)
        {
            
            bool isValidMontant = float.TryParse(txtMontant.Text, out number);
            montantFormat = number.ToString("0.00");
            montant = txtMontant.Text;
            if (String.IsNullOrEmpty(nom))
            {
                errorProvider.SetError(txtMontant, "le nom ne peut être vide");
                txtMontant.BackColor = Color.Red;

            }
            else
            {
                if (isValidMontant && (montantFormat == montant))
                {
                    errorProvider.SetError(txtMontant, "");
                    txtMontant.BackColor = Color.Green;
                }
                else
                {
                    errorProvider.SetError(txtMontant, "le montant doit être au format #.##");
                    txtMontant.BackColor = Color.Red;
                }
            }
         
        }

        private void TxtCodeValidated(object sender, EventArgs e)
        {
            code = txtCode.Text;
            if (String.IsNullOrEmpty(code))
            {
                errorProvider.SetError(txtCode, "le nom ne peut être vide");
                txtCode.BackColor = Color.Red;

            }else
            {
                if (Regex.IsMatch(code, codePattern))
                {
                    errorProvider.SetError(txtCode, "");
                    txtCode.BackColor = Color.Green;
                }
                else
                {
                    errorProvider.SetError(txtCode, "le Code Postal doit être au format : 00000");
                    txtCode.BackColor = Color.Red;
                }
            }
         
        }

        private void BtnEffacerTxtBox(object sender, EventArgs e)
        {
            
            txtNom.Clear();
            errorProvider.SetError(txtNom, String.Empty);
            txtNom.BackColor = Color.Empty;
            txtDate.Clear();
            errorProvider.SetError(txtDate, String.Empty);
            txtDate.BackColor = Color.Empty;
            txtMontant.Clear();
            errorProvider.SetError(txtMontant, String.Empty);
            txtMontant.BackColor = Color.Empty;
            txtCode.Clear();
            errorProvider.SetError(txtCode, String.Empty);
            txtCode.BackColor = Color.Empty;
        }

        private void BtnValiderTxtBox(object sender, EventArgs e)
        {
            bool errorNomEmpty = errorProvider.GetError(txtMontant) == "";
            bool errorDateEmpty = errorProvider.GetError(txtDate) == "";
            bool errorMontantEmpty = errorProvider.GetError(txtMontant) == "";
            bool errorCodeEmpty = errorProvider.GetError(txtCode) == "";
         
            if (errorNomEmpty && errorDateEmpty && errorMontantEmpty && errorCodeEmpty)
            {
                MessageBox.Show("Nom : " + txtNom.Text + Environment.NewLine +
                       "Date : " + txtDate.Text + Environment.NewLine +
                       "Montant : " + txtMontant.Text + Environment.NewLine +
                       "Code : " + txtCode.Text,
                       "Validation effectuée",
                       MessageBoxButtons.OK);

                DialogResult dr = MessageBox.Show
                                ("Fin de l’application ?", "FIN",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            
        }

  /*      private bool IsErrorTxtBox(string uhu)
        {
            TextBox box = sender as TextBox;
             
            if (errorProvider.GetError(box) == "")
            {
                
                return true;
            }
        }*/
    }
}