
namespace ColorHexClass
{
    public partial class Form1 : Form
    {
        private ElementColorChanged redValue;
        private ElementColorChanged greenValue;
        private ElementColorChanged blueValue;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            redValue = new ElementColorChanged(hsbRed, numRedText, label2, Color.Red);
            greenValue = new ElementColorChanged(hsbGreen, numGreenText, label1, Color.Green);
            blueValue = new ElementColorChanged(hsbBlue, numBlueText, label3, Color.Blue);
        }

        private void SetFinalColor()
        {
            lblColorSelect.BackColor = Color.FromArgb(redValue.GetValue(), greenValue.GetValue(),blueValue.GetValue());
        }

        private void NumValueChanged(object sender, EventArgs e)
        {
            NumericUpDown myNud = (NumericUpDown)sender;
            ElementColorChanged element = (ElementColorChanged)myNud.Tag;
            element.SetValue((int)myNud.Value);
            SetFinalColor();
        }

        private void ScrollValueChanged(object sender, ScrollEventArgs e)
        {
            HScrollBar myHsb = (HScrollBar)sender;
            ElementColorChanged element = (ElementColorChanged)myHsb.Tag;
            element.SetValue(myHsb.Value);
        }
    }
}