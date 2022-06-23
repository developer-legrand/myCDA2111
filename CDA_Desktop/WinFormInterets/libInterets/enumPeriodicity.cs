using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libInterets
{
    internal enum EnumInterestRate
    {
        monthly = 1,
        bimonthly = 2,
        quarterly = 3,
        biannual = 6,
        annual = 12
    }
    internal enum EnumNumberOfPayement
    {
        monthly = 12,
        bimonthly = 6,
        quarterly = 3,
        biannual = 2,
        annual = 1
    }
    internal enum EnumPeriodicity 
    {
        mensuelle ,
        bimensuelle,
        trimestrielle,
        semestrielle,
        annuelle 
    }
}
