using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimensionPointObject
{
	class TwoDimensionPoint
	{
		private int _xPoint;
		private int _yPoint;

		public TwoDimensionPoint() //defaut constructor
		{
			this._xPoint = 0;
			this._yPoint = 0;
		}

		public TwoDimensionPoint(int abscissaPoint, int ordinatePoint) //parameters constructor
		{
			this._xPoint = abscissaPoint;
			this._yPoint = ordinatePoint;
		}

		public int Xpoint
		{
			get { return _xPoint; }
			set { _xPoint = value; }
		}
		public int Ypoint
		{
			get { return _yPoint; }
			set { _yPoint = value; }
			//get => yPoint;
			//set => yPoint = value; 
		}

        public override string ToString()
        {
            return ($"({Xpoint}, {Ypoint})") ;
        }
	
	}
}
