namespace libInterets
{
    public class Loan
    {
        public string Name { get; set; }
        public int LoanAmount { get; set; }
        public int Duration { get; set; }
        public int Interest { get; set; }
        public int Peridocity { get; set; }
        private List<string> dsPeriodicity;
        private List<int> dsPeriodicityValue;

        public Loan(string _name, int _loanAmount, int _duration, int _interest)
        {
            Name = _name;
            LoanAmount = _loanAmount;
            Duration = _duration; 
            Interest = _interest;

            dsPeriodicity = new List<string>() { "Mensuelle", "Bimestrielle", "Trimestrielle", "Semestrielle", "Annuelle" };
            dsPeriodicityValue = new List<int>() { 1, 2, 3, 6, 12 };

        }

        //Montant de remboursement = K* (t / (1 –(1 + t) puissance(-n)))
        // loanSum * ( interest/(1-(1+t) puissance(-durationMonth)
        public double AmountPeriodicalCalculation()
        {
            double monthlInterest = ((double)Interest / 100D / 4D); 
            double result = LoanAmount *(monthlInterest/(1-Math.Pow(1+ monthlInterest, -Duration)));
            return result;
        }
    }
}