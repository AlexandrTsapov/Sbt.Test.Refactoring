using Sbt.Test.Refactoring.Commands;
using Sbt.Test.Refactoring.Executors;
using Sbt.Test.Refactoring.Models;
using Sbt.Test.Refactoring.Models.Converters;
using Sbt.Test.Refactoring.Property;

namespace Sbt.Test.Refactoring.Units
{
    public class Tractor : UnitBase, IMovingForward, ITurningClockwise, IPositioning, IOrienting
    {
        private readonly IMoverForward _moverForward;
        private readonly ITurnerClockwise _turnerClockwise;
        private readonly ConverterPointOrientation _converter;

        public Point Position { get; } = Constants.DefaultPosition;

        public Point Direction { get; } = Constants.DefaultDirection;

        public Orientation Orientation => _converter.PointToOrientation(Direction);

        public Tractor(
            Field field,
            IMoverForward moverForward,
            ITurnerClockwise turnerClockwise,
            ConverterPointOrientation converter)
            : base(field)
        {
            _moverForward = moverForward;
            _turnerClockwise = turnerClockwise;
            _converter = converter;
        }

        public void MoveForwards()
        {
            _moverForward.MoveForwards(_field, Position, Direction);
        }

        public void TurnClockwise()
        {
            _turnerClockwise.TurnClockwise(Direction);
        }
    }
}
