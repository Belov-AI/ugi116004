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
