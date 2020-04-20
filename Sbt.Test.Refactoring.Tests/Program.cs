using Sbt.Test.Refactoring.Collections;
using Sbt.Test.Refactoring.Commands;
using Sbt.Test.Refactoring.Executors;
using Sbt.Test.Refactoring.Property;
using Sbt.Test.Refactoring.Units;
using System.Collections.Generic;
using System.Linq;
using Unity;

namespace Sbt.Test.Refactoring.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            ContainerRegistrar.Register(container);

            var units = new List<UnitBase>
            {
                container.Resolve<Stone>(),
                container.Resolve<Tractor>(),
                container.Resolve<Wind>()
            };

            units.ExequteOfType<IMovingForward>(unit => unit.MoveForwards());
            units.ExequteOfType<ITurningClockwise>(unit => unit.TurnClockwise());

            var position = units.OfType<IPositioning>().Select(unit => unit.Position).ToArray();
            var orientation = units.OfType<IOrienting>().Select(unit => unit.Orientation).ToArray();
        }
    }
}
