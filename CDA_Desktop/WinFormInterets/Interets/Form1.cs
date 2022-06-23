using libInterets;

namespace Interets
{
    public partial class Form1 : Form
    {

        Loan resultLoan;
        LoanViewModel validateLoan;
        string name;
        int interestRate;
        int duration;
        int amountLoan;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtBoxName.Focus();        
            lblDurationMonth.Text = "1";
            rbtnSeven.Tag = 7;
            rbtnEight.Tag = 8;
            rbtnNine.Tag = 9;
            rbtnSeven.Checked = true;
        }
        private void lstPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LargeSmallScrollChange();
        }
        private void hsbDurationMonth_Scroll(object sender, ScrollEventArgs e)
        {
            lblDurationMonth.Text = hsbDurationMonth.Value.ToString();
            
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            // attribute name value to Loan Class
            name = txtBoxName.Text;
            name = name.Trim();
            txtBoxName.Text = name.Trim();
            txtBoxName.Focus();
            // attribute amountLoan value to Loan Class
            amountLoan = (int)Int64.Parse(txtBoxLoan.Text);
            // attribute duration value to Loan Class
            duration = int.Parse(lblDurationMonth.Text);
            // implement loanClass with recuperated values 
            resultLoan = new Loan(name, amountLoan, duration, interestRate);
            validateLoan = new LoanViewModel(resultLoan);
            if (!validateLoan.IsFormatName(name))
            {
                MessageBox.Show("INVALID FORMAT : only alphabetic characters and dash accepted", "ERROR");
            }
            else if (!validateLoan.IsFormatLoanAmount(amountLoan))
            {
                MessageBox.Show("INVALID FORMAT : only integers 3 to 10 Characters", "ERROR");
            }
            else
            {
                double result = resultLoan.AmountPeriodicalCalculation();
                result = result * dsPeriodicityValue[lstPeriodicity.SelectedIndex];
                result = Math.Round(result, 2);
                lblResultAmount.Text = result.ToString() + "€";
                lblResultAmount.ForeColor = Color.Red;
                lblNumberOfPayment.Text = (int.Parse(lblDurationMonth.Text) / dsPeriodicityValue[lstPeriodicity.SelectedIndex]).ToString();
                lblNumberOfPayment.Visible = true;
                lblNumberOfPayment.ForeColor = Color.Red;
                lblResultAmount.Visible = true;
                if (lblNumberOfPayment.Text == "1")
                {
                    lblReimbbursement.Text = "Remboursement";
                }
                else lblReimbbursement.Text = "Remboursements";
            }
        }
        private void LargeSmallScrollChange()
        {
            int index = lstPeriodicity.SelectedIndex;
            int value = dsPeriodicityValue[index];   
            hsbDurationMonth.LargeChange = value * 2;
            hsbDurationMonth.SmallChange = value;
            hsbDurationMonth.Minimum = value;
            hsbDurationMonth.Maximum = 300 + (value * 2 - 1 );
            hsbDurationMonth.Value = value;
            lblDurationMonth.Text = value.ToString();
        }
        private void RbtnInterestRate_Checked(object sender, EventArgs e)
        {
            // attribute InterestRate Value by radioButton checked
            RadioButton radioButtonChecked = (RadioButton)sender;
            interestRate = int.Parse(radioButtonChecked.Tag.ToString());
        }
    }
}