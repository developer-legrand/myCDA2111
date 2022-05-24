using System;

namespace dimensionPointObject
{
    class Program
    {
        static void Main(string[] args)
        {
			int xFirstPoint;
			int yFirstPoint;
			int xSecondPoint;
			int ySecondPoint;
			int xThirdPoint;
			int yThirdPoint;
			int zThirdPoint;
			string segmentName;

			SegmentPointTwoDimension mySegment;
			TwoDimensionPoint firstPoint = new(3, 2);
			TwoDimensionPoint secondPoint = new(4, 4);
			ThreeDimensionPoint thirdPoint = new(1, 6, 7);

			xFirstPoint = firstPoint.Xpoint;
			yFirstPoint = firstPoint.Ypoint;
			xSecondPoint = secondPoint.Xpoint;
			ySecondPoint = secondPoint.Ypoint;
			xThirdPoint = thirdPoint.Xpoint;
			yThirdPoint = thirdPoint.Ypoint;
			zThirdPoint = thirdPoint.Zpoint;
			
			mySegment = new("paul", firstPoint, secondPoint);
			segmentName = mySegment.MySegmentName;

			Console.WriteLine($"les coordonnées du premier point sont x: {xFirstPoint} et y: {yFirstPoint}");
            Console.WriteLine($"----------------------------------------------------------------------------");
			Console.WriteLine($"les coordonnées du second point sont x: {xSecondPoint} et y: {ySecondPoint}");
			Console.WriteLine($"----------------------------------------------------------------------------");
			Console.WriteLine($"les coordonnées du troisième point sont x: {xThirdPoint}, y: {yThirdPoint} et z: {zThirdPoint}");
            Console.WriteLine($"----------------------------------------------------------------------------");

            Console.WriteLine($"mon segment {segmentName} commence du point A{firstPoint.ToString()} au point B{secondPoint.ToString()}");
           
		}
    }
}
