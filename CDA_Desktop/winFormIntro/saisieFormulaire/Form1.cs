using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace saisieFormulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string namePattern = @"^[a-zA-Z]{1,30}$";
        private string datePattern = @"^[0-3]{2}[0-9]\/[0-9]+\/[0-9]+$";
        private string codePattern = @" ^\d{5}$";
        private string nom;
        private string date;
        private float montant;
        private string code;

        bool verifyAllForm;
        ErrorProvider textForm = new();
        

        private void BtnValiderClick(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void BtnEffacerClick(object sender, EventArgs e)
        {

        }

        private void ValidateForm()
        {
            if (ValidateName() && ValidateDate() && ValidateMontant() && ValidateCodePostal())
            {
                 MessageBox.Show("Nom : " + txtNom.Text + Environment.NewLine +
                                           "Date : " + txtDate.Text + Environment.NewLine +
                                           "Montant : " + txtMontant.Text + Environment.NewLine +
                                           "Code : " + txtCodePostal.Text,
                                           "Validation effectuée",
                                           MessageBoxButtons.OK);
            } else
            {
                txtNom.Focus();
            }
 
        }

        private bool ValidateName()
        {
            nom = txtNom.Text;
            if (String.IsNullOrEmpty(nom))
            {
                textForm.SetError(txtNom, "le nom ne peut être vide");   
                txtNom.BackColor = Color.Red;
                return false;
            }
            if (Regex.IsMatch(nom, namePattern))
            {
                textForm.SetError(txtNom, "seul les caractères alphabétiques, \"-\"  sont acceptés");
                txtNom.Clear();
                return false;
            }
            else 
            {
                return true;
            }
           
        }

        private bool ValidateDate()
        {
            return false;
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