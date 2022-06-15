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

        private void hsbDurationMonth_Scroll(object sender, ScrollEventArgs e)
        {
            MonthSelected();
            lblDurationMonth.Text = hsbDurationMonth.Value.ToString();
        }

        private void MonthSelected()
        {
            string periodicity = dsPeriodicity[lstPeriodicity.SelectedIndex].ToString();
            switch (periodicity)
            {
                case "Mensuelle": 
                    hsbDurationMonth.LargeChange = 1;
                    hsbDurationMonth.SmallChange = 1;
                    
                    break;
                case "Bimestrielle":
                    hsbDurationMonth.LargeChange = 2;
                    hsbDurationMonth.SmallChange = 2;
                    
                    break;
                case "Trimestrielle":
                    hsbDurationMonth.LargeChange = 3;
                    hsbDurationMonth.SmallChange = 3;
                    
                    break;
                case "Semestrielle":
                    hsbDurationMonth.LargeChange = 6;
                    hsbDurationMonth.SmallChange = 6;
                   
                    break;
                case "Annuelle":
                    hsbDurationMonth.LargeChange = 12;
                    hsbDurationMonth.SmallChange = 12;
                    
                    break;
                default:
                    MessageBox.Show("Toto n'a rien sélectionné");
                    break;
            } 
        }
    }
}