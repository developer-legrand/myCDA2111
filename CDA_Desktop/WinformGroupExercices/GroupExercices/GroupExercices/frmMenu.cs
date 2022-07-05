using Menu.frmMenuLib;
using Menu.ImportApp;

namespace GroupExercices
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
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
            myFormBuilder.CreateInstance().Show();
        }
    }
}