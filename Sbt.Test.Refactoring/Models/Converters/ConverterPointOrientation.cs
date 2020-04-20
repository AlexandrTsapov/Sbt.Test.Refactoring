using System.Collections.Generic;

namespace Sbt.Test.Refactoring.Models.Converters
{
    public class ConverterPointOrientation
    {
        public Orientation PointToOrientation(Point point)
        {
            var southEast = point.X > point.Y;
            var northEast = point.X > -point.Y;

            if (southEast && northEast)
            {
                return Orientation.East;
            }
            else if (southEast && !northEast)
            {
                return Orientation.South;
            }
            else if (!southEast && northEast)
            {
                return Orientation.North;
            }
            else
            {
                return Orientation.West;
            }
        }

        public Point OrientationToPoint(Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.North:
                    return new Point(0, 1);
                case Orientation.East:
                    return new Point(1, 0);
                case Orientation.West:
                    return new Point(-1, 0);
                case Orientation.South:
                    return new Point(0, -1);
                default:
                    throw new KeyNotFoundException();
            }
        }
    }
}
