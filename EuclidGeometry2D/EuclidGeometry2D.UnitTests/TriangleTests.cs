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
    public class TriangleTests
    {
        [Test]
        public void ConstructorTest()
        {
            //Arrange
            var a = new Point(1, 1);
            var b = new Point(3, 1);
            var c = new Point(3, 3);

            //Act
            var t = new Triangle(a, b, c);

            //Assert
            Assert.AreSame(a, t.A);
            Assert.AreSame(b, t.B);
            Assert.AreSame(c, t.C);
        }

        [Test]
        public void SideAB_Test()
        {
            var t = GetMyTriangle();

            Assert.AreSame(t.A, t.AB.A);
            Assert.AreSame(t.B, t.AB.B);
        }

        [Test]
        public void SideBC_Test()
        {
            var t = GetMyTriangle();

            Assert.AreSame(t.B, t.BC.A);
            Assert.AreSame(t.C, t.BC.B);
        }

        [Test]
        public void SideAC_Test()
        {
            var t = GetMyTriangle();

            Assert.AreSame(t.A, t.AC.A);
            Assert.AreSame(t.C, t.AC.B);
        }

        [Test]
        public void Area_MyTriangle_1SquareUnit()
        {
            var triangle = GetMyTriangle();

            var area = triangle.Area;

            Assert.AreEqual(1, area, Geometry.Epsilon);
        }

        [Test]
        public void GetEnumerator_MyTriangle_VertexesInRightOrder()
        {
            var t = GetMyTriangle();
            var vertexes = new[] { t.A, t.B, t.C };
            var i = 0;

            foreach (var vertex in t)
                Assert.AreSame(vertexes[i++], vertex);
        }

        [Test]
        public void Rotate_MyTriangle()
        {
            var triangle = GetMyTriangle();
            var newVertexes = new[] {
                new Point(2 - Math.Sqrt(2) * Math.Sin(DegreesToRadians(15)),
                    2 - Math.Sqrt(2) * Math.Cos(DegreesToRadians(15))),
                new Point(2 + Math.Sqrt(2) * Math.Cos(DegreesToRadians(15)),
                    2 - Math.Sqrt(2) * Math.Sin(DegreesToRadians(15))),
                new Point(2 + Math.Sqrt(3) / 2, 2.5)
            };

            triangle.Rotate(new Point(2, 2), 30);
            var i = 0;

            foreach (var vertex in triangle)
                Assert.IsTrue(newVertexes[i++] == vertex);
        }

        private Triangle GetMyTriangle()
        {
            return new Triangle(new Point(1, 1), new Point(3, 1), new Point(3, 2));
        }

        private double DegreesToRadians(double angle)
        {
            return angle * Math.PI / 180;
        }
    }
}
