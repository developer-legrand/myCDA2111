using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ajoutFormulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string nomPattern = @"^[a-zA-Z]+[-]?[a-zA-Z]+$";
        private string codePattern = @"^\d{5}$";
        private string nom;
        private float number;
        private string date;
        private string montant;
        private string montantFormat;
        private string code;

        private ErrorProvider textNomForm = new();
        private ErrorProvider textDateForm = new();
        private ErrorProvider textMontantForm = new();
        private ErrorProvider textCodeForm = new();
      
        
        private void btnValiderForm(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            bool trueNom = ValidateName();
            bool trueDate = ValidateDate();
            bool trueMontant = ValidateMontant();
            bool trueCode= ValidateCodePostal();
            if (trueNom && trueDate && trueMontant && trueCode)
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
            else
            {
                txtNom.Focus();
            }

        }

        private bool ValidateName()
        {
            nom = txtNom.Text;
            if (String.IsNullOrEmpty(nom))
            {
                textNomForm.SetError(txtNom, "le nom ne peut être vide");
                txtNom.BackColor = Color.Red;
                return false;
            }
            if (Regex.IsMatch(nom, nomPattern))
            {
                textNomForm.SetError(txtNom, "");
                txtNom.BackColor = Color.Green;
                return true;
            }
            else
            {
                textNomForm.SetError(txtNom, "seul les caractères alphabétiques, \"-\"  sont acceptés");
                txtNom.BackColor = Color.Red;
                return false;
            }

        }

        private bool ValidateDate()
        {
            date = txtDate.Text;
            DateTime convertDate;
            if (String.IsNullOrEmpty(date))
            {
                textDateForm.SetError(txtDate, "la date ne peut être vide");
                txtDate.BackColor = Color.Red;
                return false;
                
            } else
            {
                try
                {
                    convertDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    textDateForm.SetError(txtDate, "");
                    txtDate.BackColor = Color.Green;
               
                    return true;
                }
                catch
                {
                    textDateForm.SetError(txtDate, "la date doit être au format : JJ/MM/AAAA");
                    txtDate.BackColor = Color.Red;
                    return false;
                }
               
            }
            
        }

        private bool ValidateMontant()
        {
            bool isValidMontant = float.TryParse(txtMontant.Text, out number);
            montantFormat = number.ToString("0.00");
            montant = txtMontant.Text;
            if (String.IsNullOrEmpty(montant))
            {
                textMontantForm.SetError(txtMontant, "le montant ne peut être vide");
                txtMontant.BackColor = Color.Red;
                return false;
            }
            if (isValidMontant && (montantFormat == montant))
            {
                textMontantForm.SetError(txtMontant, "");
                txtMontant.BackColor = Color.Green;
                return true;
            } 
            else
            {
                textMontantForm.SetError(txtMontant, "le montant doit être au format #.##");
                txtMontant.BackColor = Color.Red;
                return false;
            }

        }

        private bool ValidateCodePostal()
        {
            code = txtCode.Text;
            if (String.IsNullOrEmpty(code))
            {
                textCodeForm.SetError(txtCode, "le montant ne peut être vide");
                txtCode.BackColor = Color.Red;
                return false;
            }
            if (Regex.IsMatch(code,codePattern))
            {
                textCodeForm.SetError(txtCode, "");
                txtCode.BackColor = Color.Green;
                return true;
            }
            else
            {
                textCodeForm.SetError(txtCode, "le Code Postal doit être au format : 00000");
                txtCode.BackColor = Color.Red;           
                return false;
            }
        }
    }
}