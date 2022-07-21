namespace Ecf_Blanc_21_07_22
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private string dateInscription;
        private string lasDiplomaObtained;

        public Person(string firstName, string lastName, string dateInscription, string lasDiplomaObtained)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateInscription = dateInscription;
            this.lasDiplomaObtained = lasDiplomaObtained;
        }
    }
}