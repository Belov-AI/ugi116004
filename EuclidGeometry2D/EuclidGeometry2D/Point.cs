using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry2D
{
    public class Point : ICloneable
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Rotate(Point center, double angleInDegrees)
        {
            var angleInRadians = Math.PI * angleInDegrees / 180;

            var xNew = (X - center.X) * Math.Cos(angleInRadians) -
                (Y - center.Y) * Math.Sin(angleInRadians) + center.X;

            var yNew = (X - center.X) * Math.Sin(angleInRadians) +
                (Y - center.Y) * Math.Cos(angleInRadians) + center.Y;

            (X, Y) = (xNew, yNew);
        }

        public override bool Equals(object obj)
        {
            if (obj is Point point)
                return Math.Abs(X - point.X) < Geometry.Epsilon &&
                    Math.Abs(Y - point.Y) < Geometry.Epsilon;

            throw new ArgumentException();
        }

        public static bool operator ==(Point a, Point b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Point a, Point b)
        {
            return !a.Equals(b);
        }
    }
}
