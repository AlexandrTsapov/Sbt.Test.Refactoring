using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sbt.Test.Refactoring.Executors;
using Sbt.Test.Refactoring.Models;
using Sbt.Test.Refactoring.Models.Converters;
using Sbt.Test.Refactoring.Units;
using Sbt.Test.Refactoring.Units.Exceptions;

namespace Sbt.Test.Refactoring.Tests
{
    [TestClass]
    public class MoverForwardTest
    {
        private static IMoverForward _moverForward;
        private static Field _field;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            var converter = new ConverterPointOrientation();
            _moverForward = new MoverForward(converter);
            _field = new Field { East = 2, North = 2, South = 2, West = 2 };
        }

        [TestMethod]
        public void MoveForwardsByDirection()
        {
            var point = new Point(0, 0);

            _moverForward.MoveForwards(_field, point, new Point(0, 1));
            Assert.AreEqual(new Point(0, 1), point);

            _moverForward.MoveForwards(_field, point, new Point(1, 0));
            Assert.AreEqual(new Point(1, 1), point);

            _moverForward.MoveForwards(_field, point, new Point(0, -1));
            Assert.AreEqual(new Point(1, 0), point);

            _moverForward.MoveForwards(_field, point, new Point(-1, 0));
            Assert.AreEqual(new Point(0, 0), point);
        }

        [TestMethod]
        public void MoveForwardsByOrientation()
        {
            var point = new Point(0, 0);

            _moverForward.MoveForwards(_field, point, Orientation.North);
            Assert.AreEqual(new Point(0, 1), point);

            _moverForward.MoveForwards(_field, point, Orientation.East);
            Assert.AreEqual(new Point(1, 1), point);

            _moverForward.MoveForwards(_field, point, Orientation.South);
            Assert.AreEqual(new Point(1, 0), point);

            _moverForward.MoveForwards(_field, point, Orientation.West);
            Assert.AreEqual(new Point(0, 0), point);
        }

        [TestMethod]
        [ExpectedException(typeof(OutSideFieldException))]
        public void OutSideFieldByDirection()
        {
            var point = new Point(0, 0);

            _moverForward.MoveForwards(_field, point, new Point(0, 1));
            Assert.AreEqual(new Point(0, 1), point);

            _moverForward.MoveForwards(_field, point, new Point(0, 1));
            Assert.AreEqual(new Point(0, 2), point);

            _moverForward.MoveForwards(_field, point, new Point(0, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(OutSideFieldException))]
        public void OutSideFieldByOrientation()
        {
            var point = new Point(0, 0);

            _moverForward.MoveForwards(_field, point, Orientation.North);
            Assert.AreEqual(new Point(0, 1), point);

            _moverForward.MoveForwards(_field, point, Orientation.North);
            Assert.AreEqual(new Point(0, 2), point);

            _moverForward.MoveForwards(_field, point, Orientation.North);
        }
    }
}
