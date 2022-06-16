using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace libInterets
{
    internal class LoanViewModel
    {

        Loan loan;
        Regex regexEmpty = new Regex("");
        Regex regexFormat = new Regex(@"^[a-zA-Z]+[-]?[a-zA-Z]+$");

        public LoanViewModel(Loan loan)
        {
            this.loan = loan;  
        }

       public bool isNameValid(string _name)
        {
            _name = loan.Name;
            if (regexEmpty.IsMatch(_name) || regexFormat.IsMatch(_name))
            {
                return true;
            }else return false;
        }
        public bool isLoanSumValid(string _loanSum)
        { 
            bool isLoanSumInt = int.TryParse(_loanSum,out int test);
        
            if (isLoanSumInt)
            {
                loan.LoanSum = test;
            }
            return isLoanSumInt;
        }
    }
}
