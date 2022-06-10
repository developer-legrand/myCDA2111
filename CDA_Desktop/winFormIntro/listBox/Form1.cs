using System.Collections;

namespace listBox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           lstBoxElement.Items.Add(tbInputUser.Text);
        }
    }
}