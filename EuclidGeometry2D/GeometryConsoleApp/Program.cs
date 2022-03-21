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

            var point2 = point.Clone() as Point;
            PrintPoint(point2);

            Console.WriteLine();
            point.X = 3;
            PrintPoint(point);
            PrintPoint(point2);

            Console.WriteLine();
            var segment = new Segment(new Point(1, 1), new Point(3, 4));
            PrintSegment(segment);
            var segment2 = segment.Clone() as Segment;
            PrintSegment(segment2);

            Console.WriteLine();
            segment.A.X = -1;
            PrintSegment(segment);
            PrintSegment(segment2);

            var s = Geometry.CreateSegment(new Point(-1, 3), new Point(2, 5));
            //s = Geometry.CreateSegment(new Point(1, 1), new Point(1, 1));

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
