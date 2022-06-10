using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libValidationSaisie
{
    internal class DateFormatValidate
    {
        private DateTime convertDate;

        public DateFormatValidate()
        {
        
        }

        public bool IsValid()
        {
            if(DateFutureValidate() && DateFormatValidate())
            {
                return true;    
            } else
            {
                return false;
            }
        }

        private bool DateFuturetValidate(string _date)
        {

            try
            {
                convertDate = DateTime.ParseExact(_date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                return true;
            }catch(FormatException e)
            {
                throw new Exception(e.Message);
            }

        private bool DateTimeValidate(string _date)
        {

            if (convertDate <= DateTime.Now)
            {
                throw new ArgumentOutOfRangeException(
                    "La date doit être dans le futur"
                );
            }
        }
    }
}
