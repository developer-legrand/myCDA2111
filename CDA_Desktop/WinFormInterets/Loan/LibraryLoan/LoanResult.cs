

namespace Loan.LibraryLoan
{
    internal class LoanResult
    {
        public string Name { get; set; }
        public long LoanAmount { get; set; }
        public int Duration { get; set; }
        public double Interest { get; set; }


        public LoanResult(string _name, long _loanAmount, int _duration, double _interest)
        {
            Name = _name;
            LoanAmount = _loanAmount;
            Duration = _duration;
            Interest = _interest;
        }

        public double GetFinalResult()
        {
            double finalResult = Math.Round(Interest * LoanAmount, 2);
            return finalResult;
        }
    }


}
