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

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
