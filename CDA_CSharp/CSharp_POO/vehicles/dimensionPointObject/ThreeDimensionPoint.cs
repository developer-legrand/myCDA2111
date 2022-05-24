using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimensionPointObject
{
    class ThreeDimensionPoint : TwoDimensionPoint
    {
        private int _zPoint;

        public ThreeDimensionPoint(int abscissaPoint, int ordinatePoint, int heightPoint) : base (abscissaPoint, ordinatePoint)
        {
            this._zPoint = heightPoint;
        }
        public int Zpoint
        {
            get { return _zPoint; }
            set { _zPoint = value; }
        }

    }
}
