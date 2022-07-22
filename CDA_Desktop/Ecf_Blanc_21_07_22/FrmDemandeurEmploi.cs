using Ecf_Blanc_21_07_22.LibTrouverEmploi;

namespace Ecf_Blanc_21_07_22
{
    public partial class FrmDemandeurEmploi : Form
    {
        private string firstName;
        private string lastName;
        private string dateInscription;
        private string level;
        private string lasDiplomaObtained;
        private Candidate candidate;
        private ErrorValidationForm errorValidation;
        private LevelEducation[] levelEducation;
        private List<Candidate> listCandidate;
        private bool logValidation;
        private FrmInputUserValidation frmInputUserValidation;

        public FrmDemandeurEmploi()
        {
            InitializeComponent();
        }

        private void FrmTrouverEmploi_Load(object sender, EventArgs e)
        {
            listCandidate = new List<Candidate>();
            tbFirstName.Text = "toto";
            tbLastName.Text = "haricot";                   
            tbInscription.Text = "12/12/1212";
            levelEducation = new LevelEducation[]
            {
                new LevelEducation("InfBac"),
                new LevelEducation("Bac"),
                new LevelEducation("Bac+1"),
                new LevelEducation("Bac+2"),
                new LevelEducation("Bac+3"),
                new LevelEducation("Bac+4"),
                new LevelEducation("Bac+5"),
                new LevelEducation("SupBac+5")
            };

            cbLevelEducation.DataSource = levelEducation;
    }

        private void ClearInputCandidate()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Font = new Font(c.Font, FontStyle.Regular);
                    c.ForeColor = Color.Black;
                    c.Text = null;
                }
                if (c is ComboBox)
                {
                    c.ForeColor = Color.Black;
                }
            }
        }

        private void OpenInputUserValidated()
        {
            frmInputUserValidation = new FrmInputUserValidation();
            frmInputUserValidation.Show();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        { 
            //récupération des données dans le formulaire
            firstName = tbFirstName.Text;
            lastName = tbLastName.Text;
            dateInscription = tbInscription.Text;
            level = cbLevelEducation.SelectedItem.ToString();
            lasDiplomaObtained = tbLastDiploma.Text;
            //Instanciation  classe métier & validation
            errorValidation = new ErrorValidationForm();
            logValidation = errorValidation.ValidCandidateInput(firstName, lastName, dateInscription);

            //Vérification des erreurs éventuelles

            if (!errorValidation.FirstNameValidation(firstName) || String.IsNullOrEmpty(firstName))
            {
                tbFirstName.Font = new Font(tbFirstName.Font, FontStyle.Bold);
                tbFirstName.ForeColor = Color.Red;
            }
            else
            {
                tbFirstName.Font = new Font(tbFirstName.Font, FontStyle.Regular);
                tbFirstName.ForeColor = Color.Blue;
            }
            if (!errorValidation.LastNameValidation(lastName))
            {
                tbLastName.Font = new Font(tbFirstName.Font, FontStyle.Bold);
                tbLastName.ForeColor = Color.Red;
            }
            else
            {
                tbLastName.Font = new Font(tbFirstName.Font, FontStyle.Regular);
                tbLastName.ForeColor = Color.Blue;
            }
               
            if (!errorValidation.DateInscriptionValidation(dateInscription.ToString()))
            {
                tbInscription.Font = new Font(tbFirstName.Font, FontStyle.Bold);
                tbInscription.ForeColor = Color.Red;
            }
            else
            {
                tbInscription.Font = new Font(tbFirstName.Font, FontStyle.Regular);
                tbInscription.ForeColor = Color.Blue;
            }

            if (cbLevelEducation.SelectedItem == null)
            {
                cbLevelEducation.ForeColor = Color.Red;
            }
            else
            {
                cbLevelEducation.ForeColor = Color.Blue;
            }

            if (logValidation)
            {
                candidate = new Candidate(firstName, lastName, dateInscription, lasDiplomaObtained);
                listCandidate.Add(candidate);
                MessageBox.Show("LogAccount : " + listCandidate.Count().ToString() + Environment.NewLine +
                                "Firstname : " + candidate.FirstName + Environment.NewLine +
                                "Lastname : " + candidate.LastName + Environment.NewLine +
                                "Inscription Date : " + candidate.DateInscription + Environment.NewLine +
                                "Education Level : " + candidate.Level + Environment.NewLine +
                                "Last Diploma Obtained : " + candidate.LastDiplomaObtained,
                                "Validation Success",
                                MessageBoxButtons.OK);

                                DialogResult dr = MessageBox.Show
                                ("Do you want to quit ?", "Quit",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
                                    if (dr == DialogResult.No)
                                    {
                                        ClearInputCandidate();
                                        OpenInputUserValidated();
                                    }
                                if (dr == DialogResult.Yes) Application.Exit();
            }  
        }
    }
}