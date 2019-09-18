using System;

namespace MGroup.XFEM.Exceptions
{
    class IncorrectDecompositionException: Exception
    {
        public IncorrectDecompositionException()
        { }

        public IncorrectDecompositionException(string message) : base(message)
        { }

        public IncorrectDecompositionException(string message, Exception inner) : base(message, inner)
        { }
    }
}
