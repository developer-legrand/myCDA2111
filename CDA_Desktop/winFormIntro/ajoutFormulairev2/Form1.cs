using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ajoutFormulairev2
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
        // ErrorProvider on TextBox Input
        private ErrorProvider textNomError = new();
        private ErrorProvider textDateError = new();
        private ErrorProvider textMontantError = new();
        private ErrorProvider textCodeError = new();

        private void TxtNameChange(object sender, EventArgs e)
        {
            nom = txtNom.Text;
            if (Regex.IsMatch(nom, nomPattern))
            {
                textNomError.SetError(txtNom, "");
                txtNom.BackColor = Color.Green;
            }
            else
            {
                textNomError.SetError(txtNom, "seul les caractères alphabétiques, \"-\"  sont acceptés");
                txtNom.BackColor = Color.Red;
            }
        }

        private void TxtDateChange(object sender, EventArgs e)
        {
            date = txtDate.Text;
            DateTime convertDate;
            try
            {
                convertDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                textDateError.SetError(txtDate, "");
                txtDate.BackColor = Color.Green;
            }
            catch
            {
                textDateError.SetError(txtDate, "la date doit être au format : JJ/MM/AAAA");
                txtDate.BackColor = Color.Red;   
            }
        }

        private void TxtMontantChange(object sender, EventArgs e)
        {
            
            bool isValidMontant = float.TryParse(txtMontant.Text, out number);
            montantFormat = number.ToString("0.00");
            montant = txtMontant.Text;
            if (isValidMontant && (montantFormat == montant))
            {
                textMontantError.SetError(txtMontant, "");
                txtMontant.BackColor = Color.Green;  
            }
            else
            {
                textMontantError.SetError(txtMontant, "le montant doit être au format #.##");
                txtMontant.BackColor = Color.Red;              
            }
        }

        private void TxtCodeChange(object sender, EventArgs e)
        {
            code = txtCode.Text;
            if (Regex.IsMatch(code, codePattern))
            {
                textCodeError.SetError(txtCode, "");
                txtCode.BackColor = Color.Green;   
            }
            else
            {
                textCodeError.SetError(txtCode, "le Code Postal doit être au format : 00000");
                txtCode.BackColor = Color.Red;
            }
        }

        private void BtnEffacerTxtBox(object sender, EventArgs e)
        {
            txtNom.Clear();
            textNomError.SetError(txtNom, String.Empty);
            txtNom.BackColor = Color.Empty;
            txtDate.Clear();
            textDateError.SetError(txtDate, String.Empty);
            txtDate.BackColor = Color.Empty;
            txtMontant.Clear();
            textMontantError.SetError(txtMontant, String.Empty);
            txtMontant.BackColor = Color.Empty;
            txtCode.Clear();
            textCodeError.SetError(txtCode, String.Empty);
            txtCode.BackColor = Color.Empty;
        }

        private void BtnValiderTxtBox(object sender, EventArgs e)
        {
            if ()
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
    }
}