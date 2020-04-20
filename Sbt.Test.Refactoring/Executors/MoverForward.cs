using Sbt.Test.Refactoring.Models;
using Sbt.Test.Refactoring.Models.Converters;
using Sbt.Test.Refactoring.Units;

namespace Sbt.Test.Refactoring.Executors
{
    public class MoverForward : IMoverForward
    {
        private readonly ConverterPointOrientation _converter;

        public MoverForward(ConverterPointOrientation converter)
        {
            _converter = converter;
        }

        public void MoveForwards(Field field, Point position, Point direction)
        {
            position.Add(direction);
            field.CheckInside(position);
        }

        public void MoveForwards(Field field, Point position, Orientation orientation)
        {
            var direction = _converter.OrientationToPoint(orientation);
            MoveForwards(field, position, direction);
        }
    }
}
