using Sbt.Test.Refactoring.Models;
using Sbt.Test.Refactoring.Property;

namespace Sbt.Test.Refactoring.Units
{
    public class Stone : UnitBase, IPositioning
    {
        public Point Position { get; } = Constants.DefaultPosition;

        public Stone(Field field)
            : base(field)
        {
        }
    }
}
