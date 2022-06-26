using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Loan.LibraryLoan
{
    internal class LoanViewModel
    {
        private LoanResult loan;
        Regex regexFormatName = new Regex(@"^[a-zA-Z]*[-]?[a-zA-Z]*$");
        Regex regexFormatLoanAmount = new Regex(@"^\d{3,10}$");
        Regex regextEmpty = new Regex("");
        

        public LoanViewModel()
        {
            this.loan = loan;
        }
        public bool IsFormatName(string _name)
        {
            if (regexFormatName.IsMatch(_name))
            {
                return true;
            }
            else return false;
        }
        public bool IsFormatLoanAmount(long _loanSum)
        {
            if (regexFormatLoanAmount.IsMatch(_loanSum.ToString()))
            {
                return true;
            }
            else return false;
        }
        public bool IsEmptyLoanAmount(long _loanSum)
        {
           /* _loanSum = loan.LoanAmount;*/
            if (regextEmpty.IsMatch(_loanSum.ToString()))
            {
                return true;
            }
            else return false;
        }
    }
}
