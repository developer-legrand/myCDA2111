

using System.ComponentModel;

namespace Loan.LibraryLoan
{
    public class LoanResult
    {
        public string Name { get; set; }
        public long LoanAmount { get; set; }
        public int Duration { get; set; }
        public double Interest { get; private set; }
        public int Periodicity { get; set; }
        public int NumberRepayments { get { return (Duration / Periodicity); } }
        public event PropertyChangedEventHandler OnUpdate;
        private static LoanResult? instance = null;

        public LoanResult(string _name, long _loanAmount, int _duration, double _interest, int _peridocity)
        {
            Name = _name;
            LoanAmount = _loanAmount;
            Duration = _duration;
            Interest = _interest;
            Periodicity = _peridocity;
        }

        public static LoanResult GetInstance()
        {
            if (instance == null)
            {
                instance = new LoanResult("", 0, 1, 0.07D, 1);
            }
            return instance;
        }

        public double GetSumPerPeriodicity()
        {
            return LoanAmount * Interest / (1 - Math.Pow(1 + Interest, -NumberRepayments));
        }

        private void Updated()
        {
        if (OnUpdate != null)
            {
                OnUpdate(this, new PropertyChangedEventArgs(nameof(Interest)));
            }
        }
    }


}
