using System.Text.RegularExpressions;

namespace libInterets
{
    public class LoanViewModel
    {

        public Loan loan;
        Regex regexFormatName = new Regex(@"^[a-zA-Z]*[-]?[a-zA-Z]*$");
        Regex regexFormatLoanAmount = new Regex(@"^\d{3,10}$");
        Regex regextEmpty = new Regex("");
        public LoanViewModel(Loan loan)
        {
            this.loan = loan;  
        }
        public bool IsFormatName(string _name)
        {
            _name = loan.Name;
            if (regexFormatName.IsMatch(_name))
            {
                return true;
            }
            else return false;
        }
        public bool IsFormatLoanAmount(int _loanSum)
        {
            _loanSum = loan.LoanAmount;
            if (regexFormatLoanAmount.IsMatch(_loanSum.ToString()))
            {
                return true;
            }
            else return false;
        }
        public bool IsEmptyLoanAmount(int _loanSum)
        {
            _loanSum = loan.LoanAmount;
            if (regextEmpty.IsMatch(_loanSum.ToString()))
            {
                return true;
            }
            else return false;
        }
    }
}
