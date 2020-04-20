namespace Sbt.Test.Refactoring.Units
{
    public abstract class UnitBase
    {
        protected Field _field;

        public UnitBase(Field field)
        {
            _field = field;
        }
    }
}
