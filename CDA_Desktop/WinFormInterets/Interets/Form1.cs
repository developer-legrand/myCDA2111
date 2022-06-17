using libInterets;

namespace Interets
{
    public partial class Form1 : Form
    {

        List<string> dsPeriodicity;
        List<int> dsPeriodicityValue;
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
            dsPeriodicity = new List<string>() { "Mensuelle", "Bimestrielle", "Trimestrielle", "Semestrielle", "Annuelle" };
            dsPeriodicityValue = new List<int>() { 1, 2, 3, 6, 12 };
            lstPeriodicity.DataSource = dsPeriodicity;
            txtBoxName.Focus();
            rbtnSeven.Checked = true;
            lblDurationMonth.Text = "1";
        }

        private void lstPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            PeriodicitySelected();

            NewLabelPeriodicty(lblDurationMonth.Text);
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

        private void PeriodicitySelected()
        {
            string periodicity = dsPeriodicity[lstPeriodicity.SelectedIndex].ToString();
            switch (periodicity)
            {
                case "Mensuelle":
                    LargeSmallScrollChange();
                    break;
                case "Bimestrielle":
                    LargeSmallScrollChange();
                    break;
                case "Trimestrielle":
                    LargeSmallScrollChange();
                    break;
                case "Semestrielle":
                    LargeSmallScrollChange();
                    break;
                case "Annuelle":
                    LargeSmallScrollChange();
                    break;
                default:
                    MessageBox.Show("Toto n'a rien sélectionné");
                    break;
            }
        }

        private void LargeSmallScrollChange()
        {
            hsbDurationMonth.Value = 1;
            lblDurationMonth.Text = "1";
            int index = lstPeriodicity.SelectedIndex;
            int _value = dsPeriodicityValue[index];   
            hsbDurationMonth.LargeChange = _value * 2;
            hsbDurationMonth.SmallChange = _value;
        }


    }
}