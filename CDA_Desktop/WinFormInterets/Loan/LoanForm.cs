using Loan.LibraryLoan;


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


        public LoanForm()
        {
            InitializeComponent();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            tbName.Focus();
            rbSeven.Tag = 0.07;
            rbEight.Tag = 0.08;
            rbNine.Tag = 0.09;
            rbSeven.Checked = true;
            loanResult = new LoanResult(name, loanAmount, duration, interestRate);
            loanValidator = new LoanViewModel();
          
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            
            name = tbName.Text;
            if (!loanValidator.IsFormatName(name))
            {
                tbName.BackColor = Color.Red;    
            }
            else
            {
                tbName.BackColor = Color.Green;
            }
        }

        private void TbLoan_TextChanged(object sender, EventArgs e)
        {
            
            loanAmount = long.Parse(tbLoan.Text) ;
            if (!loanValidator.IsEmptyLoanAmount(loanAmount) || !loanValidator.IsFormatLoanAmount(loanAmount))
            {
                tbLoan.BackColor = Color.Red;
            } else
            {
                tbLoan.BackColor = Color.Green;
            }
        }

        private void RbValueTag_Checked(object sender, EventArgs e)
        {
            RadioButton radioButtonChecked = (RadioButton)sender;
            interestRate = (double)radioButtonChecked.Tag;
        }

    
    }
}