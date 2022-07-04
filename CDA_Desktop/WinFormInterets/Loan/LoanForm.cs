using Loan.LibraryLoan;
using System.ComponentModel;

namespace Loan
{
    public partial class LoanForm : Form
    {
        
        private LoanViewModel loanValidator;
        private LoanResult loanResult;

        public LoanForm()
        {
            InitializeComponent();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            rbSeven.Tag = 0.07D;
            rbEight.Tag = 0.08D;
            rbNine.Tag = 0.09D;
            tbName.Focus();
            
            loanResult = LoanResult.GetInstance();
            loanResult.OnUpdate += LoanUpdated;
            rbSeven.Checked = true;

        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            loanResult.Name = tbName.Text;
        }

        private void TbLoan_TextChanged(object sender, EventArgs e)
        
        {
            loanResult.LoanAmount = long.Parse(tbLoan.Text);
        }

        private void RbValueTag_Checked(object sender, EventArgs e)
        {
            RadioButton radioButtonChecked = (RadioButton)sender;
            loanResult.SetInterestRate((double)radioButtonChecked.Tag);
            MessageBox.Show(radioButtonChecked.Tag.ToString());
        }

        private void LoanUpdated(object sender, PropertyChangedEventArgs e)
        {
            if (sender is LoanResult loanSender)
            {
                lblNumberOfPayment.Text = loanSender.NumberRepayments.ToString();
                lblResultAmount.Text = loanSender.GetSumPerPeriodicity().ToString();
            }
        }
    }
}