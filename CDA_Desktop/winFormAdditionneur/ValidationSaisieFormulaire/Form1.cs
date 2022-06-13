using libValidationSaisie;

namespace ValidationSaisieFormulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameValidate = new NameValidate();
            dateValidate = new DateValidate();
            amounttValidate = new AmountValidate();
            zipCodeValidate = new ZipCodeValdate();
        }
    }
}