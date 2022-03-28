using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EuclidGeometry2D;

namespace EuclidGeometry2D.UnitTests
{
    [TestFixture]
    public class PointTests
    {
        [Test]
        public void Constructor_SomeCoordinates_RightFieldsValues()
        {
            //Arrange & Act
            var p = new Point(1, 2);

            //Assert
            Assert.AreEqual(1, p.X);
            Assert.AreEqual(2, p.Y);
        }

        [Test]
        public void Equals_TwoSamePoints_True()
        {
            var a = new Point(1, 2);
            var b = new Point(1, 2);

            Assert.IsTrue(a.Equals(b));
            Assert.AreNotSame(a, b);
        }

        [Test]
        public void RotateTest()
        {
            var point = new Point(2, 0);
            var center = new Point(1, 1);

            point.Rotate(center, 45);

            Assert.AreEqual(1 + Math.Sqrt(2), point.X, Geometry.Epsilon);
            Assert.AreEqual(1, point.Y, Geometry.Epsilon);
        }
    }
}
