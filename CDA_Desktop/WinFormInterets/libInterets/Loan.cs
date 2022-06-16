namespace libInterets
{
    public class Loan
    {
        public string Name { get; set; }
        public int LoanSum { get; set; }
        private int Duration { get; set; }
        private int Interest { get; set; }

        public Loan(string _name , int _loanSum, int _duration, int _interest)
        {
            Name = _name;
            LoanSum = _loanSum;
            Duration = _duration; 
            Interest = _interest;
        }

        //Montant de remboursement = K* (t / (1 –(1 + t) puissance(-n)))
        // borrowedSum * ( interest/(1-(1+t) puissance(-durationMonth)

        public double AmountPeriodicalCalculation()
        {
            double monthlInterest = ((double)Interest / 12D)/100D;
            double result = LoanSum *(monthlInterest/(1-Math.Pow(1+ monthlInterest, -Duration)));
            return result;
        }
    }
}