using Loan.LibraryLoan;
using System.ComponentModel;

namespace Loan
{
    public partial class LoanForm : Form
    {
        
        private LoanViewModel loanValidator;
        private LoanResult loanResult;
        private string name;
        private int duration;
        private long loanAmount;
        private double interestRate;
        private int periodicity;


        public LoanForm()
        {
            InitializeComponent();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            rbSeven.Tag = 0.07;
            rbEight.Tag = 0.08;
            rbNine.Tag = 0.09;
            tbName.Focus();
            rbSeven.Checked = true;
            loanResult = LoanResult.GetInstance();
            loanResult.OnUpdate += LoanUpdated;

        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            name = tbName.Text;
            MessageBox.Show(loanResult.Name.ToString());
        }

        private void TbLoan_TextChanged(object sender, EventArgs e)
        {
            loanAmount = long.Parse(tbLoan.Text); 
        }

        private void RbValueTag_Checked(object sender, EventArgs e)
        {
            RadioButton radioButtonChecked = (RadioButton)sender;
            interestRate = (double)radioButtonChecked.Tag;
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