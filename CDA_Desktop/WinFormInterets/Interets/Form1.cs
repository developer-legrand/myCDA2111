namespace Interets
{
    public partial class Form1 : Form
    {
        string name;
        int loan;
        List<string> dsPeriodicity;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsPeriodicity = new List<string>() { "Mensuelle", 
                                                "Bimestrielle",
                                                "Trimestrielle",
                                                "Semestrielle",
                                                "Annuelle" };
            lstPeriodicity.DataSource = dsPeriodicity;
            txtBoxName.Focus();
            rbtnSeven.Checked = true;
            lblDurationMonth.Text = "1";
        }

        private void MonthSelected()
        {
            string periodicity = dsPeriodicity[lstPeriodicity.SelectedIndex].ToString();
            switch (periodicity)
            {
                case "Mensuelle":
                    hsbDurationMonth.LargeChange = 10;
                    hsbDurationMonth.SmallChange = 1;
                    break;
                case "Bimestrielle":
                    hsbDurationMonth.LargeChange = 10;
                    hsbDurationMonth.SmallChange = 2;
                    break;
                case "Trimestrielle":
                    hsbDurationMonth.LargeChange = 10;
                    hsbDurationMonth.SmallChange = 3;
                    break;
                case "Semestrielle":
                    hsbDurationMonth.LargeChange = 10;
                    hsbDurationMonth.SmallChange = 6;
                    break;
                case "Annuelle":
                    hsbDurationMonth.LargeChange = 20;
                    hsbDurationMonth.SmallChange = 12;
                    break;
                default:
                    MessageBox.Show("Toto n'a rien sélectionné");
                    break;
            }
        }

        private void lstPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthSelected();
            NewLabelPeriodicty(lblDurationMonth.Text);
        }

        private string NewLabelPeriodicty(string _currentIntPeriodicty)
        {
            MessageBox.Show(_currentIntPeriodicty);
            return _currentIntPeriodicty;
        }

        private void hsbDurationMonth_Scroll(object sender, ScrollEventArgs e)
        {
            lblDurationMonth.Text = hsbDurationMonth.Value.ToString();
        }
    }
}