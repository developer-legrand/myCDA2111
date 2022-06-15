namespace ColorHex
{
    public partial class Form1 : Form
    {
        int redColor;
        int greenColor;
        int blueColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Scroll_Changed(object sender, ScrollEventArgs e)
        {     
            numBlueText.Value = hsbBlue.Value;
            numGreenText.Value = hsbGreen.Value;
            numRedText.Value = hsbRed.Value;
        }

        private void numColorText_Changed(object sender, EventArgs e)
        {
            redColor = (int)numRedText.Value;
            greenColor = (int)numGreenText.Value;
            blueColor = (int)numBlueText.Value;
            hsbBlue.Value = blueColor;
            hsbGreen.Value = greenColor;
            hsbRed.Value = redColor;
            Color lblColor = Color.FromArgb(redColor, greenColor, blueColor);
            lblColorSelect.BackColor = lblColor;
        } 
    }
}