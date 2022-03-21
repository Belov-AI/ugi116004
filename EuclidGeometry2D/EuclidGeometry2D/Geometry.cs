using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry2D
{
    public static class Geometry
    {
        public static readonly double Epsilon = 1e-8;
        public static Segment CreateSegment(Point a, Point b)
        {
            if (a == b)
                throw new ArgumentException("Вырожденный отрезок");

            return new Segment(a, b);
        }

        public static Triangle CreateTriangle(Point a, Point b, Point c)
        {
            var t = new Triangle(a, b, c);

            if (t.AB.IsContainsPoint(t.C) ||
                t.AC.IsContainsPoint(t.B) ||
                t.BC.IsContainsPoint(t.A))
                throw new ArgumentException("Вырожденный треугольник");

            return t;
        }
    }
}
