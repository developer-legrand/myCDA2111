using Loan.LibraryLoan;

namespace Loan.UserControls
{
    public partial class PeriodUserControl : UserControl
    {
        public LoanResult LoanResult { get; set; }
        public int Periodicity => periodicityUsed[lbPeriodicity.SelectedIndex].PeriodicityDuration;
        
        public readonly Periodicity[] periodicityUsed = new Periodicity[]
        {
            new Periodicity("Mensuelle", 1),
            new Periodicity("Bimestrielle", 2),
            new Periodicity("Trimestrielle", 3),
            new Periodicity("Semestrielle", 6),
            new Periodicity("Annuelle", 12),
        };
        private void PeriodUserControl_Load(object sender, EventArgs e)
        {
            lbPeriodicity.DataSource = periodicityUsed;
            lbPeriodicity.SelectedIndex = 0;
            LoanResult.GetInstance();
        }
        public PeriodUserControl()
        {
            InitializeComponent();
        }

        private void lbPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            hsbDuration.Minimum = Periodicity;
            hsbDuration.SmallChange = Periodicity;
            hsbDuration.LargeChange = Periodicity * 2;
            hsbDuration.Maximum = 300 + (hsbDuration.LargeChange - 1);
            hsbDuration.Value = Periodicity;
            hsbDuration_ValueChanged(sender, e);
        }

        private void hsbDuration_ValueChanged(object sender, EventArgs e)
        {
            lblDuration.Text = hsbDuration.Value.ToString();
        }

    }
}
