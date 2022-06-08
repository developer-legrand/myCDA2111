

namespace checkBoxRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listChechChoix_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Color labelCaptive = new Color();
       
        private void tbInputUser_TextChanged(object sender, EventArgs e)
        {
          
            labelInputUserControl.Text = tbInputUser.Text;
            if (!String.IsNullOrEmpty(labelInputUserControl.Text))
            {
                gbChoix.Enabled = true;       
            } else
            {
                gbChoix.Enabled = false;
            }
        }

        private void cbCouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCouleurFond.Checked)
            {
                gbFond.Visible = true;
            }
            else
            {
                labelInputUserControl.BackColor = Color.Empty;
                gbFond.Visible = false;
            }    
        }

        private void cbCouleurCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            labelCaptive = labelInputUserControl.ForeColor;
            if (cbCouleurCaracteres.Checked)
            {
                gbCaractere.Visible = true;
            }
            else
            {
                gbCaractere.Visible = false;
            }
           
        }

        private void cbCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCasse.Checked)
            {
                gbCasse.Visible = true;
            }
            else gbCasse.Visible = false;
        }

        private void rbFondRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFondRouge.Checked)
            {
                labelInputUserControl.BackColor = Color.Red;
            }
            else labelInputUserControl.BackColor = Color.Empty;
        }

        private void rbFondVert_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFondVert.Checked)
            {
                labelInputUserControl.BackColor = Color.Green;
            }
            else labelInputUserControl.BackColor = Color.Empty;
        }

        private void rbFondBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFondBleu.Checked)
            {
                labelInputUserControl.BackColor = Color.Blue;
            }
            else labelInputUserControl.BackColor = Color.Empty;
        }

        private void rbCaractereRouge_CheckedChanged(object sender, EventArgs e)
        {

            if (rbCaractereRouge.Checked)
            {
                labelInputUserControl.ForeColor = Color.Red;
            }
            else labelInputUserControl.ForeColor = Color.Empty;
        }
        private void rbCaractereBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCaractereBlanc.Checked)
            {
                labelInputUserControl.ForeColor = Color.White;
            }
            else labelInputUserControl.ForeColor = Color.Empty;
        }

        private void rbCaractereNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCaractereNoir.Checked)
            {
                labelInputUserControl.ForeColor = Color.Black;
            }
            else labelInputUserControl.ForeColor = labelCaptive;  
        }

        private void rbMinuscule_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinuscule.Checked)
            {
                labelInputUserControl.Text = labelInputUserControl.Text.ToLower();
            }
        }

        private void rbMajuscule_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMajuscule.Checked)
            {
                labelInputUserControl.Text = labelInputUserControl.Text.ToUpper();
            }
        }

      
    }
}