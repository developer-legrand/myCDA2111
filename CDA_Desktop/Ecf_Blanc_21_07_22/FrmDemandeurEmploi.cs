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
        private bool verifyValidation;
        private List<Candidate> listCandidate;
        private int logAccount;

        public FrmDemandeurEmploi()
        {
            InitializeComponent();
        }

        private void FrmTrouverEmploi_Load(object sender, EventArgs e)
        {


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


        private void btnValidate_Click(object sender, EventArgs e)
        {
            verifyValidation = true;
            //récupération des données dans le formulaire
            firstName = tbFirstName.Text;
            lastName = tbLastName.Text;
            dateInscription = tbInscription.Text;
            level = cbLevelEducation.SelectedItem.ToString();
            lasDiplomaObtained = tbLastDiploma.Text;
            //Instanciation  classe métier & validation
            errorValidation = new ErrorValidationForm();
            //Vérification des erreurs éventuelles
            if (!errorValidation.FirstNameValidation(firstName) || String.IsNullOrEmpty(firstName))
            {
                tbFirstName.BackColor = Color.Red;
                tbFirstName.Font = new Font(tbFirstName.Font, FontStyle.Bold);
            }
            else
            {
                tbFirstName.BackColor = Color.Blue;
                tbFirstName.Font = new Font(tbFirstName.Font, FontStyle.Regular);
                verifyValidation = false;
            }
            if (!errorValidation.LastNameValidation(lastName))
            {
                tbLastName.BackColor = Color.Red;
                tbLastName.Font = new Font(tbFirstName.Font, FontStyle.Bold);
            }
            else
            {
                tbLastName.BackColor = Color.Blue;
                tbLastName.Font = new Font(tbFirstName.Font, FontStyle.Regular);
                verifyValidation = false;
            }
               
            if (!errorValidation.DateInscriptionValidation(dateInscription.ToString()))
            {
                tbInscription.BackColor = Color.Red;
                tbInscription.Font = new Font(tbFirstName.Font, FontStyle.Bold);
            }
            else
            {
                tbInscription.BackColor = Color.Blue;
                tbInscription.Font = new Font(tbFirstName.Font, FontStyle.Regular);
                verifyValidation =  false;
            }

            if (cbLevelEducation.SelectedItem == null)
            {
                cbLevelEducation.BackColor = Color.Red;
            }
            else
            {
                cbLevelEducation.BackColor = Color.Blue;
                verifyValidation = true;
            }

            if (!verifyValidation)
            {
                listCandidate = new();
                candidate = new Candidate(firstName, lastName, dateInscription, lasDiplomaObtained);
                listCandidate.Add(candidate);
                MessageBox.Show("LogAccount : " + listCandidate.Count().ToString() + Environment.NewLine +
                                "Firstname : " + candidate.FirstName + Environment.NewLine +
                                "Lastname : " + candidate.LastName + Environment.NewLine +
                                "Inscription Date : " + candidate.DateInscription + Environment.NewLine +
                                "Education Level : " + candidate.Level + Environment.NewLine +
                                "Last Diloma Obtained " + candidate.LastDiplomaObtained,
                                "Validation Success",
                                MessageBoxButtons.OK);

                                DialogResult dr = MessageBox.Show
                                ("Do you want to quit ?", "Quit",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
                                if (dr == DialogResult.Yes)
                                {
                                    Application.Exit();
                                }
            } 
        }
    }
}