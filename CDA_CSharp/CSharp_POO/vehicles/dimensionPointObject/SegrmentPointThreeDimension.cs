using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimensionPointObject
{
    class SegmentPointThreeDimension
    {
        private ThreeDimensionPoint _firstPoint;
        private ThreeDimensionPoint _secondPoint;
        string _segmentName;

        public SegmentPointThreeDimension() //defaut constructor
        {
            this._segmentName = "NULL";
            this._firstPoint = new(0, 0, 0);
            this._secondPoint = new(1, 1, 1);
        }

        public SegmentPointThreeDimension(string _name, ThreeDimensionPoint _myFirstPoint, ThreeDimensionPoint _mySecondPoint)
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
