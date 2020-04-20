using Sbt.Test.Refactoring.Models;
using System;

namespace Sbt.Test.Refactoring.Executors
{
    public class TurnerClockwise : ITurnerClockwise
    {
        private static readonly int _countOrientations = Enum.GetValues(typeof(Orientation)).Length;

        public void TurnClockwise(Point direction)
        {
            direction.TurnClockwise();
        }

        public Orientation TurnClockwise(Orientation orientation)
        {
            return (int)++orientation < _countOrientations
                ? orientation
                : 0;
        }
    }
}
