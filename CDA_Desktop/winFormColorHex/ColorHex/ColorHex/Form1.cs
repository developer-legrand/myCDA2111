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
            redColor = (int)numRedText.Value;
            greenColor = (int)numGreenText.Value;
            blueColor = (int)numBlueText.Value;
        }

        private void Scroll_Changed(object sender, ScrollEventArgs e)
        {     
            numBlueText.Value = hsbBlue.Value;
            numGreenText.Value = hsbGreen.Value;
            numRedText.Value = hsbRed.Value;
        }

        private void numColorText_Changed(object sender, EventArgs e)
        {
            hsbBlue.Value = blueColor;
            hsbGreen.Value = greenColor;
            hsbRed.Value = redColor;
        }

        private void lblColorSelect_BackColorChanged(object sender, EventArgs e)
        {
           
            Color lblColor = Color.FromArgb(Convert.ToByte(redColor), Convert.ToByte(greenColor), Convert.ToByte(blueColor));
            lblColorSelect.BackColor = lblColor;
        }

        
    }
}