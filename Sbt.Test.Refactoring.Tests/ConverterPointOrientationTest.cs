using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sbt.Test.Refactoring.Models;
using Sbt.Test.Refactoring.Models.Converters;

namespace Sbt.Test.Refactoring.Tests
{
    [TestClass]
    public class ConverterPointOrientationTest
    {
        [TestMethod]
        public void ConverterPointToOrientation()
        {
            var converter = new ConverterPointOrientation();

            var orientation = converter.PointToOrientation(new Point(-1, 0));
            Assert.AreEqual(Orientation.West, orientation);

            orientation = converter.PointToOrientation(new Point(0, -1));
            Assert.AreEqual(Orientation.South, orientation);

            orientation = converter.PointToOrientation(new Point(1, 0));
            Assert.AreEqual(Orientation.East, orientation);

            orientation = converter.PointToOrientation(new Point(0, 1));
            Assert.AreEqual(Orientation.North, orientation);
        }

        [TestMethod]
        public void ConverterOrientationToPoint()
        {
            var converter = new ConverterPointOrientation();

            var direction = converter.OrientationToPoint(Orientation.West);
            Assert.AreEqual(new Point(-1, 0), direction);

            direction = converter.OrientationToPoint(Orientation.South);
            Assert.AreEqual(new Point(0, -1), direction);

            direction = converter.OrientationToPoint(Orientation.East);
            Assert.AreEqual(new Point(1, 0), direction);

            direction = converter.OrientationToPoint(Orientation.North);
            Assert.AreEqual(new Point(0, 1), direction);
        }
    }
}
