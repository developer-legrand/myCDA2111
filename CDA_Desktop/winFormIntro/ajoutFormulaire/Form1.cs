using System.Globalization;
using System.Text.RegularExpressions;

namespace ajoutFormulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string namePattern = @"^[a-zA-Z]+[-]?[a-zA-Z]+$";
        private string codePattern = @" ^\d{5}$";
        private string nom;
        private string date;
        private float montant;
        private string code;

        private ErrorProvider textNomForm = new();
        private ErrorProvider textDateForm = new();

        private void btnValiderForm(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            ValidateName();
            ValidateDate();

            if (ValidateName() && ValidateDate())
            {
                MessageBox.Show("Nom : " + txtNom.Text + Environment.NewLine +
                                          "Date : " + txtDate.Text + Environment.NewLine +
                                          "Montant : " + txtMontant.Text + Environment.NewLine +
                                          "Code : " + txtCode.Text,
                                          "Validation effectuée",
                                          MessageBoxButtons.OK);
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
            if (Regex.IsMatch(nom, namePattern))
            {
                textNomForm.SetError(txtNom, "seul les caractères alphabétiques, \"-\"  sont acceptés");
                txtNom.BackColor = Color.Red;
                txtNom.Clear();
                return false;
            }
            else
            {
                txtNom.BackColor = Color.Green;
                return true;
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
                    txtDate.BackColor = Color.Green;
                    MessageBox.Show(date);
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
            return false;
        }

        private bool ValidateCodePostal()
        {
            return false;
        }
    }
}