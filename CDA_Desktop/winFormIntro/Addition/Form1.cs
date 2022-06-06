namespace Addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button myButton = sender as Button;   
            txtBoxView.Text += myButton.Text;
        }

        private void btn_ViewClear_Click(object sender, EventArgs e)
        {
            txtBoxView.Text = "";
        }

        private void btn_Resultat_Click(object sender, EventArgs e)
        {
            string myResult = txtBoxView.Text;
           
            string[] myResultSplit = myResult.Split('+');
            int[] myResultInt = Array.ConvertAll(myResultSplit, int.Parse);
            int myResultFinal = myResultInt.Sum();
            txtBoxView.Text = myResult + " = " + myResultFinal;
        }
    }
}