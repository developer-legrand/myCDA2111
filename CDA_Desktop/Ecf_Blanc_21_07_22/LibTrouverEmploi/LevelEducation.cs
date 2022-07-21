using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecf_Blanc_21_07_22.LibTrouverEmploi
{
    public class LevelEducation
    {

        public string Level { get; set; }

        public LevelEducation(string _level)
        {
            Level = _level;
        }
        override public string ToString()
        {
            return Level;
        }


    }
}
