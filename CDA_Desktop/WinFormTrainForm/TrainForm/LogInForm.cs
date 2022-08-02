using HeidiTrainForm.App;

namespace TrainForm
{
    public partial class LogInHeidi : Form
    {
        public LogInHeidi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreatAccount_Click(object sender, EventArgs e)
        {
            InscriptionForm inscription = new InscriptionForm(this);
            inscription.Show();
            this.Hide();
        }
    }
}