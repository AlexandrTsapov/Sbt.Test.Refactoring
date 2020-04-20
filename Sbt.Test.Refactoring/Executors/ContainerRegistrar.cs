using Unity;

namespace Sbt.Test.Refactoring.Executors
{
    public static class ContainerRegistrar
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterSingleton<IMoverForward, MoverForward>();
            container.RegisterSingleton<ITurnerClockwise, TurnerClockwise>();
        }
    }
}
