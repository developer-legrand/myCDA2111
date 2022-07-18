namespace Loan.LibraryLoan
{
    public class Periodicity
    {
        public string PeriodicityName { get; }
        public int PeriodicityDuration { get; }

        public Periodicity(string _periodicityName, int _periodicityDuration)
        {
            PeriodicityName = _periodicityName;
            PeriodicityDuration = _periodicityDuration;
        }

        override public string ToString()
        {
            return PeriodicityName;
        }
    }
}
