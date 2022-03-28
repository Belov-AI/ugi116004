using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry2D
{
    public class Triangle
    {
        public Point A;
        public Point B;
        public Point C;

        public Segment AB
        {
            get
            {
                return new Segment(A, B);
            }
        }
        public Segment AC
        {
            get
            {
                return new Segment(A, C);
            }
        }

        public Segment BC
        {
            get
            {
                return new Segment(B, C);
            }
        }

        public double Area
        {
            get
            {
                var a = AB.Length;
                var b = AC.Length;
                var c = BC.Length;
                var p = (a + b + c ) / 2;

                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void Rotate(Point center, double angleInDegrees)
        {
            A.Rotate(center, angleInDegrees);
            B.Rotate(center, angleInDegrees);
            C.Rotate(center, angleInDegrees);
        }
    }
}
