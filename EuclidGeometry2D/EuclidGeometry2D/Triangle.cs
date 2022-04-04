using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry2D
{
    public class Triangle : ICloneable
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

        public IEnumerator<Point> GetEnumerator()
        {
            yield return A;
            yield return B;
            yield return C;
        }

        public void Rotate(Point center, double angleInDegrees)
        {
            foreach (var vertex in this)
                vertex.Rotate(center, angleInDegrees);
        }

        public object Clone()
        {
            return new Triangle(
                this.A.Clone() as Point, 
                this.B.Clone() as Point, 
                this.C.Clone() as Point
                );
        }
    }
}
