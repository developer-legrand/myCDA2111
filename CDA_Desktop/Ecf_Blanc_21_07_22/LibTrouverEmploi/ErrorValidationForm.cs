using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ecf_Blanc_21_07_22.LibTrouverEmploi
{
    class ErrorValidationForm
    {
        private string firstNamePattern = @"^[a-zA-Z]+[-]?[a-zA-Z]+$";
        private string lastNamePattern = @"^[a-zA-Z]+[ ]?[a-zA-Z]+$";
        private string lastDiplomaPattern = "";
        private string datePattern = "dd/MM/yyyy";
        private Candidate person;
        private string firstName;
        private string lastName;

        public ErrorValidationForm()
        {
        }

        public bool FirstNameValidation(string firstName)
        {
            try
            {
                return Regex.IsMatch(firstName, firstNamePattern);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
          
        }
        public bool LastNameValidation(string lastName)
        { 
            try
            {
                return Regex.IsMatch(lastName, lastNamePattern);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public bool DateInscriptionValidation(string date)
        {
            DateTime convertDate;
                try
                { 
                convertDate = DateTime.ParseExact(date, datePattern, CultureInfo.InvariantCulture);
                    if(convertDate > DateTime.Now)
                    {
                        return false;
                    }
                    else  return true;
                }
            
                catch(Exception e)
                {
                    /*throw new Exception(e.ToString());*/
                    return false;
                }
        }

        public bool LastDiplomaObtained(string diploma)
        {
            try
            {
                return Regex.IsMatch(diploma, lastDiplomaPattern);
                return true;
            }
            catch (Exception e)
            {
                /*throw new Exception(e.ToString());*/
                return false;
            }
        }
    }
}
