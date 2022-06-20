namespace libInterets
{
    public class Loan
    {
        public string Name { get; set; }
        public int LoanAmount { get; set; }
        public int Duration { get; set; }
        public int Interest { get; set; }

        public Loan(string _name, int _loanAmount, int _duration, int _interest)
        {
            Name = _name;
            LoanAmount = _loanAmount;
            Duration = _duration; 
            Interest = _interest;
        }

        //Montant de remboursement = K* (t / (1 –(1 + t) puissance(-n)))
        // loanSum * ( interest/(1-(1+t) puissance(-durationMonth)
        public double AmountPeriodicalCalculation()
        {
            double monthlInterest = ((double)Interest / 12D)/100D;
            double result = LoanAmount *(monthlInterest/(1-Math.Pow(1+ monthlInterest, -Duration)));
            return result;
        }
    }
}