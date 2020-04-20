using Sbt.Test.Refactoring.Commands;
using Sbt.Test.Refactoring.Executors;
using Sbt.Test.Refactoring.Models;
using Sbt.Test.Refactoring.Property;

namespace Sbt.Test.Refactoring.Units
{
    public class Wind : UnitBase, ITurningClockwise, IOrienting
    {
        private readonly ITurnerClockwise _turnerClockwise;

        public Orientation Orientation { get; private set; } = Constants.DefaultOrientation;

        public Wind(
            Field field,
            ITurnerClockwise turnerClockwise)
            : base(field)
        {
            _turnerClockwise = turnerClockwise;
        }

        public void TurnClockwise()
        {
            Orientation = _turnerClockwise.TurnClockwise(Orientation);
        }
    }
}
