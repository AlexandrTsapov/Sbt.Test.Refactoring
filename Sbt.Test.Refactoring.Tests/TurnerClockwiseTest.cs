using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sbt.Test.Refactoring.Executors;
using Sbt.Test.Refactoring.Models;

namespace Sbt.Test.Refactoring.Tests
{
    [TestClass]
    public class TurnerClockwiseTest
    {
        [TestMethod]
        public void TurnerByDirection()
        {
            var turner = new TurnerClockwise();
            var direction = new Point(0, 1);

            turner.TurnClockwise(direction);
            Assert.AreEqual(new Point(-1, 0), direction);

            turner.TurnClockwise(direction);
            Assert.AreEqual(new Point(0, -1), direction);

            turner.TurnClockwise(direction);
            Assert.AreEqual(new Point(1, 0), direction);

            turner.TurnClockwise(direction);
            Assert.AreEqual(new Point(0, 1), direction);
        }

        [TestMethod]
        public void TurnerByOrientation()
        {
            var turner = new TurnerClockwise();
            var orientation = Orientation.North;

            orientation = turner.TurnClockwise(orientation);
            Assert.AreEqual(Orientation.West, orientation);

            orientation = turner.TurnClockwise(orientation);
            Assert.AreEqual(Orientation.South, orientation);

            orientation = turner.TurnClockwise(orientation);
            Assert.AreEqual(Orientation.East, orientation);

            orientation = turner.TurnClockwise(orientation);
            Assert.AreEqual(Orientation.North, orientation);
        }
    }
}
