namespace ajoutformulaireV4
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
    }
}