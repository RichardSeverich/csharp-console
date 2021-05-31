using System;

namespace SensitiveInformationConsole.Src.Exceptions
{
    [Serializable]
    internal class InvalidCommandException : Exception
    {
        internal InvalidCommandException()
        {
        }

        internal InvalidCommandException(string message)
            : base(string.Format("Invalid Command: {0}", message))
        {
        }
    }
}
