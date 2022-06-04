using System.Text.RegularExpressions;

namespace ajoutFormulairev2
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

        private void txtBoxChange(object sender, EventArgs e)
        {
            nom = txtNom.Text;
            if (String.IsNullOrEmpty(nom))
            {
                textNomForm.SetError(txtNom, "le nom ne peut être vide");
                txtNom.BackColor = Color.Red;
                
            }
            if (Regex.IsMatch(nom, nomPattern))
            {
                textNomForm.SetError(txtNom, "");
                txtNom.BackColor = Color.Green;
               
            }
            else
            {
                textNomForm.SetError(txtNom, "seul les caractères alphabétiques, \"-\"  sont acceptés");
                txtNom.BackColor = Color.Red;
 
            }

        }
    }
}