using System;

namespace Sbt.Test.Refactoring.Units.Exceptions
{
    public class OutSideFieldException : Exception
    {
        public OutSideFieldException()
        {
        }

        public OutSideFieldException(string message)
            : base(message)
        {
        }

        public OutSideFieldException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
