using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormToutEmbal.LibToutEmbal
{
    class Box
    {
        private string TypeBox;
        public bool DefectiveBox { get; private set; }
        private Random randDefectiveBox;
        public Box(string typeBox)
        {
            TypeBox = typeBox;
            DefectiveBox = randDefectiveBox.NextDouble() >= 0.05; 
        }

    }
}
