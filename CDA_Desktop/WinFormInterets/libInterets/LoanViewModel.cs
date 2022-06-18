using System.Text.RegularExpressions;

namespace libInterets
{
    public class LoanViewModel
    {

        public Loan loan;
        Regex regexEmpty = new Regex("");
        Regex regexFormat = new Regex(@"toto");
        /*new Regex(@"^[a-zA-Z]+[-]?[a-zA-Z]+$");*/
        public LoanViewModel(Loan loan)
        {
            this.loan = loan;  
        }

       public bool IsNameValid(string _name)
        {
            _name = loan.Name;
            if (regexEmpty.IsMatch("") || regexFormat.IsMatch(_name))
            {
                return true;
            }
            else return false;
        }
        public bool IsLoanSumValid(string _loanSum)
        { 
            bool isLoanSumInt = int.TryParse(_loanSum,out int test);
        
            if (isLoanSumInt)
            {
                loan.LoanSum = test;
                return isLoanSumInt;
            }
            else return false;
        }
    }
}
