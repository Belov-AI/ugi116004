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
    public class GeometryTest
    {
        [Test]
        public void CreateSegment_TwoDifferentPoint_CreationSuccessful()
        {
            var a = new Point(1, 1);
            var b = new Point(3, 2);

            var segment = Geometry.CreateSegment(a, b);

            Assert.AreSame(a, segment.A);
            Assert.AreSame(b, segment.B);
        }

        [Test]
        public void CreateSegment_DegeneratedSegment_ArgumentException()
        {
            var a = new Point(1, 1);
            var b = new Point(1, 1);

            ArgumentException ex = Assert.Throws<ArgumentException>(
                () => Geometry.CreateSegment(a, b));

            Assert.AreEqual("Вырожденный отрезок", ex.Message);
        }

        [Test]
        public void CreateTriange_Nondegenerated_CreationSuccessful()
        {
            var a = new Point(1, 1);
            var b = new Point(3, 1);
            var c = new Point(3, 3);

            var t = Geometry.CreateTriangle(a, b, c);

            Assert.AreSame(a, t.A);
            Assert.AreSame(b, t.B);
            Assert.AreSame(c, t.C);
        }

        [Test]
        public void CreateTriangle_Degenerated_AgumentException()
        {
            var a = new Point(1, 1);
            var b = new Point(2, 1.5);
            var c = new Point(3, 2);

            ArgumentException ex = Assert.Throws<ArgumentException>(
                () => Geometry.CreateTriangle(a, b, c));

            Assert.AreEqual("Вырожденный треугольник", ex.Message);
        }

    }
}
