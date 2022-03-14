﻿using System;
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
    }
}
