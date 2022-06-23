
namespace checkBoxRadioButtonV2
{
    public partial class Caractere : Form
    { 
        public Caractere()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            //gestion des Groupbox Visible
            cbCouleurFond.Tag = bgFond;
            cbCouleurCaractere.Tag = bgCaractere;
            cbCasse.Tag = bgCasse;
            //gestionde la couleur de fond du label
            rbFondBleu.Tag = Color.Blue;
            rbFondRouge.Tag = Color.Red;
            rbFondVert.Tag = Color.Green;
            //gestion de la couleur du texte du label
            rbCaractereBlanc.Tag = Color.White;
            rbCaractereNoir.Tag = Color.Black;
            rbCaractereRouge.Tag = Color.Red;
        }

        private void TbInputUser_TextChanged(object sender, EventArgs e)
        {
            labelInputUserControl.Text = tbInputUser.Text;
            if (rbMinuscule.Checked)
            {
                labelInputUserControl.Text = tbInputUser.Text.ToLower();
            }
            if (rbMajuscule.Checked)
            {
                labelInputUserControl.Text = tbInputUser.Text.ToUpper();
            }
            /* if (!String.IsNullOrEmpty(labelInputUserControl.Text))
            {
                gbChoix.Enabled = true;
            }
            else
            {
                gbChoix.Enabled = false;
            }*/
            gbChoix.Enabled = (!string.IsNullOrEmpty(labelInputUserControl.Text)) ? true : false;
        }

        private void CheckBoxSelect(object sender, EventArgs e)
        {
            CheckBox myCheckBox = (CheckBox)sender;
            GroupBox myGroupBox = (GroupBox)myCheckBox.Tag;
            myGroupBox.Visible = myCheckBox.Checked;
            /*            if (!bgCaractere.Visible)
                        {
                            rbCaractereRouge.Checked = false;
                            rbCaractereBlanc.Checked = false;
                            rbCaractereNoir.Checked = false;
                            labelInputUserControl.ForeColor = Color.Empty;
                        }
                        if (!bgFond.Visible)
                        {
                            rbFondRouge.Checked = false;
                            rbFondBleu.Checked = false;
                            rbFondVert.Checked = false;
                            labelInputUserControl.BackColor = Color.Empty;
                        }
                        if (!bgCasse.Visible)
                        {
                            rbMajuscule.Checked = false;
                            rbMinuscule.Checked = false;
                            labelInputUserControl.Text = tbInputUser.Text;
                        }*/
         foreach(RadioButton radioButton in myGroupBox.Controls)
            {
                if(!myGroupBox.Visible)
                    radioButton.Checked = false;
                if(!bgFond.Visible) labelInputUserControl.BackColor = Color.Empty;
                if(!bgCaractere.Visible) labelInputUserControl.ForeColor = Color.Empty;
                if(!bgCasse.Visible) labelInputUserControl.Text = tbInputUser.Text;
            }
        }

        private void RbFondSelect(object sender, EventArgs e)
        {
            RadioButton myRadioButton = (RadioButton)sender;
            labelInputUserControl.BackColor = (Color)myRadioButton.Tag;
        }

        private void RbCaractereSelect(object sender, EventArgs e)
        {
            RadioButton myRadioButton = (RadioButton)sender;
            labelInputUserControl.ForeColor = (Color)myRadioButton.Tag;
        }

        private void RbCasseSelect(object sender, EventArgs e)
        {
            RadioButton myRadioButton = (RadioButton)sender;
            //gestion de la casse du texte du label
            rbMajuscule.Tag = tbInputUser.Text.ToUpper();
            rbMinuscule.Tag = tbInputUser.Text.ToLower();
            labelInputUserControl.Text = (string)myRadioButton.Tag;
        }
    }    
}