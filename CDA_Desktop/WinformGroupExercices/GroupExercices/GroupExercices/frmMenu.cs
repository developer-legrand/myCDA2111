using Menu.frmMenuLib;
using Menu.ImportApp;

namespace GroupExercices
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            dateStatus.Text = DateTime.Now.ToString("dd MMMM yyyy");
            menuAdditionneur.Tag = new FormBuilder<Additionneur>(this);
            menuFormulaire.Tag = new FormBuilder<Formulaire>(this);
            menuCaractere.Tag = new FormBuilder<Caractere>(this);
            menuCouleur.Tag = new FormBuilder<ColorForm>(this);
            menuElement.Tag = new FormBuilder<Element>(this);
        }

        private void AppClickOpener(object sender, EventArgs e)
        {
            ToolStripMenuItem myMenu = (ToolStripMenuItem)sender;
            IFormBuilder myFormBuilder = (IFormBuilder)myMenu.Tag;
            
            /*myFormBuilder.CreateInstance().Show();*/
            Form f = myFormBuilder.CreateInstance();
            f.FormClosing += App_Closing;
            lastActionStatus.Text = f.Text;
            lastActionStatus.Visible = true;
            f.Show();
        }
        public void App_Closing(object sender, FormClosingEventArgs e)
        {
            if (sender is Form form)
            {
                lastActionStatus.Text = form.Text + " fermé";
            }
        }
    }
}