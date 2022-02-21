using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuclidGeometry2D;

namespace GeometryConsoleApp
{
    class Program
    {
        static void Main()
        {
            var point = new Point(1, 2);
            PrintPoint(point);

            var segment = new Segment(new Point(1, 1), new Point(3, 4));
            PrintSegment(segment);

            segment.A.X = -1;
            PrintSegment(segment);

            var s = Geometry.CreateSegment(new Point(-1, 3), new Point(2, 5));
            s = Geometry.CreateSegment(new Point(1, 1), new Point(1, 1));

            Console.ReadKey();
        }

        static void PrintPoint(Point p)
        {
            Console.WriteLine($"точка ({p.X}; {p.Y})");
        }

        static void PrintSegment(Segment s)
        {
            Console.WriteLine($"отрезок [({s.A.X}; {s.A.Y}), ({s.B.X}; {s.B.Y})] длиной {s.Length:F3}");
        }
    }
}
