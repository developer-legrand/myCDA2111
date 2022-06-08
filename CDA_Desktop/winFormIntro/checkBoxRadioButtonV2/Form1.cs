
namespace checkBoxRadioButtonV2
{
    public partial class Form1 : Form
    {
        string toUpper;
        string toLower;

        public Form1()
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
            if (!String.IsNullOrEmpty(labelInputUserControl.Text))
            {
                gbChoix.Enabled = true;
            }
            else
            {
                gbChoix.Enabled = false;
            }
        }

        private void CheckBoxSelect(object sender, EventArgs e)
        {
            CheckBox myCheckBox = (CheckBox)sender;
            GroupBox myGroupBox = (GroupBox)myCheckBox.Tag;
            myGroupBox.Visible = myCheckBox.Checked;
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
            //gestion de la casse du texte du label
            rbMajuscule.Tag = labelInputUserControl.Text.ToUpper();
            rbMinuscule.Tag = labelInputUserControl.Text.ToLower();
       
        }
    }    
}