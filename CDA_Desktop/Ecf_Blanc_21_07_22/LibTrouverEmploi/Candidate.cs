using Ecf_Blanc_21_07_22.LibTrouverEmploi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecf_Blanc_21_07_22
{
    public class Candidate
    {

        private string _lastDiplomaObtained;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? LastDiplomaObtained { get; set; }
        public string  Level { get; set; }
        public string DateInscription { get; set; }

        public Candidate(String _firstName, String _lastName, string _level, string _dateInscritpion )
            {
                FirstName = _firstName;
                LastName = _lastName;
                LastDiplomaObtained = _lastDiplomaObtained;
                Level = _level;
                DateInscription = _dateInscritpion;
            }
    }
}