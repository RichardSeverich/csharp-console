using SensitiveInformationConsole.Src.Exceptions;
using System.Collections.Generic;

namespace SensitiveInformationConsole.Src.Validators
{
    internal class ValidatorArgument
    {
        private ValidatorArgument()
        {
        }

        internal static void Validate(List<string> listArgs)
        {
            if (listArgs.Count < 1)
            {
                throw new InvalidCommandException("No arguments");
            }
        }
    }
}
