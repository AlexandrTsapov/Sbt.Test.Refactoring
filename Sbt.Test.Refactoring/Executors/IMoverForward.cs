using Sbt.Test.Refactoring.Models;
using Sbt.Test.Refactoring.Units;

namespace Sbt.Test.Refactoring.Executors
{
    public interface IMoverForward
    {
        void MoveForwards(Field field, Point position, Point direction);

        void MoveForwards(Field field, Point position, Orientation orientation);
    }
}
