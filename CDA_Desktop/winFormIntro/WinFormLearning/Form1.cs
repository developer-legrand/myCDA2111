using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopier_Click(object sender, EventArgs e)
        {          
            // recopie de la valeur saisie de la source vers la cible
            txtCible.Text = txtCible.Text + " " + txtSource.Text;
            // efface la source : on utilise la méthode Clear
            txtSource.Clear();
            // positionne le focus: on utilise la méthode Focus
            txtSource.Focus();
            DialogResult dr = MessageBox.Show("Fin de l’application ?", "FIN",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button1);
                                                if (dr == DialogResult.Yes)
                                                Application.Exit();
        }
       
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
