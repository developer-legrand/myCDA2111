using System.Globalization;
using System.Text.RegularExpressions;

namespace ajoutFormulaireValidating
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

        private void btnVlalider_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
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
                MessageBox.Show("formulaire non valide");
            }
        }
        private void txtNom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            nom = txtNom.Text;
            if (String.IsNullOrEmpty(nom))
            {
                e.Cancel = false;
                errorProvider.SetError(txtNom, "le nom ne peut être vide");
            }
            else
            {
                if (Regex.IsMatch(nom, nomPattern))
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtNom, "");
                    txtNom.BackColor = Color.Green;
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtNom, "seul les caractères alphabétiques, \"-\"  sont acceptés");
                }
            }
        }

        private void txtDate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            date = txtDate.Text;
            DateTime convertDate;
            if (String.IsNullOrEmpty(date))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDate, "le nom ne peut être vide");
            }
            else
            {
                try
                {
                    
                    convertDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    e.Cancel = false;
                    errorProvider.SetError(txtDate, "");
                    txtDate.BackColor = Color.Green;
                }
                catch
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtDate, "la date doit être au format : JJ/MM/AAAA");
                }
            }
        }

        private void txtMontant_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isValidMontant = float.TryParse(txtMontant.Text, out number);
            montantFormat = number.ToString("0.00");
            montant = txtMontant.Text;
            if (String.IsNullOrEmpty(montant))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMontant, "le nom ne peut être vide");
            }
            else
            {
                if (isValidMontant && (montantFormat == montant))
                {
                    e.Cancel = false;  
                    errorProvider.SetError(txtMontant, "");
                    txtMontant.BackColor = Color.Green;
                }
                else
                {
                    e.Cancel= true;
                    errorProvider.SetError(txtMontant, "le montant doit être au format #.##");
                }
            }
        }

        private void txtCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            code = txtCode.Text;
            if (String.IsNullOrEmpty(code))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCode, "le nom ne peut être vide");
            }
            else
            {
                if (Regex.IsMatch(code, codePattern))
                {
                    e.Cancel = false;
                    errorProvider.SetError(txtCode, "");
                    txtCode.BackColor = Color.Green;
                }
                else
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtCode, "le Code Postal doit être au format : 00000");
                }
            }
        }


        private void btnEffacer_Click(object sender, EventArgs e)
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
    }
}