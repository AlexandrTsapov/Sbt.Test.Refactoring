using Sbt.Test.Refactoring.Models;
using Sbt.Test.Refactoring.Units.Exceptions;

namespace Sbt.Test.Refactoring.Units
{
    public class Field
    {
        public int North { get; set; } = Constants.BorderNorth;
        public int West { get; set; } = Constants.BorderWest;
        public int South { get; set; } = Constants.BorderSouth;
        public int East { get; set; } = Constants.BorderEast;

        public void CheckInside(Point point)
        {
            var isInside = point.X <= East
                && point.X >= -West
                && point.Y <= North
                && point.Y >= -South;

            if (!isInside)
            {
                throw new OutSideFieldException($"Unit with position [{point}] went out of side");
            }
        }
    }
}
