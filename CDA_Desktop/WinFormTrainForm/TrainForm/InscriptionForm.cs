using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainForm;

namespace HeidiTrainForm.App
{
    public partial class InscriptionForm : Form
    {
        private LogInHeidi myLogInForm;

        public InscriptionForm()
        {
            InitializeComponent();
        }

        public InscriptionForm(LogInHeidi myLogInForm) : this()
        {
            this.myLogInForm = myLogInForm;
        }

        private void InscriptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myLogInForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myLogInForm.Show();
            this.Close();
        }
    } 
}
