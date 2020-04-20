using Sbt.Test.Refactoring.Models;

namespace Sbt.Test.Refactoring.Executors
{
    public interface ITurnerClockwise
    {
        void TurnClockwise(Point direction);

        Orientation TurnClockwise(Orientation orientation);
    }
}
