namespace Loan.LibraryLoan
{
    public class LoanResult
    {
        private long _loanAmount;
        private int _periodicity;
        public event PropertyChangedEventHandler OnUpdate;
        private static LoanResult? instance = null;
        public LoanResult()
        {
            Name = "";
            LoanAmount = 0;
            Duration = 1;
            Interest = 0.07D;
            Periodicity = 1;
        }

        public static LoanResult GetInstance()
        {
            if (instance == null)
            {
                instance = new LoanResult();
            }
            return instance;
        }

        public string Name { get; set; }
        public int Duration { get; private set; }
        public double Interest { get; private set; }
        public long LoanAmount
        {
            get => _loanAmount;
            set
            {
                _loanAmount = value;
                Updated();
            }
        }

        public int Periodicity
        {
            get => _periodicity;
            set
            {
                _periodicity = value;
                Updated();
            }
        }
        public int NumberRepayments { get { return (Duration / Periodicity); } }
        public double MonthlyInterest { get { return Interest / (12 / Periodicity); } }


        public void SetInterestRate(double newValue)
        {
            Interest = newValue;
            Updated();
        }

        public void SetNumberMonths(int newValue)
        {
            Duration = newValue;
            Updated();
        }
        public double GetSumPerPeriodicity()
        {
            return LoanAmount * MonthlyInterest / (1 - Math.Pow(1 + MonthlyInterest, -NumberRepayments));
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
