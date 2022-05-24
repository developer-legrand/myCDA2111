using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimensionPointObject
{
    class SegmentPointTwoDimension
    {
        private TwoDimensionPoint _firstPoint;
        private TwoDimensionPoint _secondPoint;
        string _segmentName;

        public SegmentPointTwoDimension() //defaut constructor
        {
            this._firstPoint = new(0, 0);
            this._secondPoint = new(1, 1);
        }

        public SegmentPointTwoDimension(string _name, TwoDimensionPoint _myFirstPoint, TwoDimensionPoint _mySecondPoint)
        {
            this._segmentName = _name;
            this._firstPoint = _myFirstPoint;
            this._secondPoint = _mySecondPoint;
        }

        public string MySegmentName
        {
            get { return _segmentName; }
            set { _segmentName = value; }
        }

        public override string ToString()
        {
            return ($"({MySegmentName}, mon point A{_firstPoint.ToString()} et mon point B{_secondPoint.ToString()}");
        }

    }
}
