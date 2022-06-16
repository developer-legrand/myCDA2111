using libInterets;

namespace Interets
{
    public partial class Form1 : Form
    {

        List<string> dsPeriodicity;
        Loan resultLoan;
        string name;
        int interestRate;
        int duration;
        int borrowedLoan;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsPeriodicity = new List<string>() { "Mensuelle", 
                                                "Bimestrielle",
                                                "Trimestrielle",
                                                "Semestrielle",
                                                "Annuelle" };
            lstPeriodicity.DataSource = dsPeriodicity;
            txtBoxName.Focus();
            rbtnSeven.Checked = true;
            lblDurationMonth.Text = "1";
            resultLoan = new Loan(name, borrowedLoan, duration, interestRate);
        }

        private void lstPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthSelected();
            NewLabelPeriodicty(lblDurationMonth.Text);
            MessageBox.Show(lblDurationMonth.Text);
        }

        private string NewLabelPeriodicty(string _currentIntPeriodicty)
        {
            return _currentIntPeriodicty;   
        }

        private void hsbDurationMonth_Scroll(object sender, ScrollEventArgs e)
        {
            lblDurationMonth.Text = hsbDurationMonth.Value.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {  
            double result = Math.Round(resultLoan.AmountPeriodicalCalculation(), 2);
            lblResultAmount.Text = result.ToString();
            MessageBox.Show(result.ToString());
        }

        private void MonthSelected()
        {
            string periodicity = dsPeriodicity[lstPeriodicity.SelectedIndex].ToString();
            switch (periodicity)
            {
                case "Mensuelle":
                    hsbDurationMonth.LargeChange = 10;
                    hsbDurationMonth.SmallChange = 1;
                    break;
                case "Bimestrielle":
                    hsbDurationMonth.LargeChange = 10;
                    hsbDurationMonth.SmallChange = 2;
                    break;
                case "Trimestrielle":
                    hsbDurationMonth.LargeChange = 12;
                    hsbDurationMonth.SmallChange = 3;
                    break;
                case "Semestrielle":
                    hsbDurationMonth.LargeChange = 18;
                    hsbDurationMonth.SmallChange = 6;
                    break;
                case "Annuelle":
                    hsbDurationMonth.LargeChange = 36;
                    hsbDurationMonth.SmallChange = 12;
                    break;
                default:
                    MessageBox.Show("Toto n'a rien sélectionné");
                    break;
            }
        }
    }
}