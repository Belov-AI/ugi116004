using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry2D
{
    public class Segment : ICloneable
    {
        public Point A;
        public Point B;

        public double Length
        {
            get
            {
                var dx = A.X - B.X;
                var dy = A.Y - B.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }

        public Segment(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public bool IsContainsPoint(Point p)
        {
            //(𝑥𝑥0−𝑥𝑥1)(𝑦𝑦2−𝑦𝑦0)−(𝑦𝑦0−𝑦𝑦1)(𝑥𝑥2−𝑥𝑥0)=0
            //(𝑥𝑥0−𝑥𝑥1)(𝑥𝑥2−𝑥𝑥0)+(𝑦𝑦0−𝑦𝑦1)(𝑦𝑦2−𝑦𝑦0)≥0

            return Math.Abs((p.X - A.X) * (B.Y - p.Y) - (p.Y - A.Y) * (B.X - p.X)) < Geometry.Epsilon &&
                (p.X - A.X) * (B.X - p.X) + (p.Y - A.Y) * (B.Y - p.Y) > -Geometry.Epsilon;
        }

        public object Clone()
        {
            return new Segment(A.Clone() as Point, B.Clone() as Point);
        }

        public void Rotate(Point center, double angleInDegrees)
        {
            A.Rotate(center, angleInDegrees);
            B.Rotate(center, angleInDegrees);
        }
    }
}
