using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuclidGeometry2D;
using NUnit.Framework;

namespace EuclidGeometry2D.UnitTests
{
    [TestFixture]
    public class SegmentTests
    {
        [Test]
        public void ConstructorTest()
        {
            var a = new Point(1, 2);
            var b = new Point(-2, 0);

            var segment = new Segment(a, b);

            Assert.AreSame(a, segment.A);
            Assert.AreSame(b, segment.B);
        }

        [TestCase(1, 1, true)]
        [TestCase(3, 2, true)]
        [TestCase(2, 1.5, true)]
        [TestCase(1, 2, false)]
        [TestCase(0, 3, false)]
        [TestCase(4, 2.5, false)]
        [TestCase(0, 0.5, false)]
        public void IsContainsPoint_SeveralPoint_ReturnsExpected(double x, double y, bool expected)
        {
            var segment = new Segment(new Point(1, 1), new Point(3, 2));
            var point = new Point(x, y);

            var result = segment.IsContainsPoint(point);

            Assert.AreEqual(expected, result);
        }
    }
}
