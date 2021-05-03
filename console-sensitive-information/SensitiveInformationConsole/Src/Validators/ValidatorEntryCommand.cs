using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationConsole.Src.Exceptions;

namespace SensitiveInformationConsole.Src.Validators
{
    internal class ValidatorEntryCommand
    {
        private ValidatorEntryCommand()
        {
        }

        internal static void Validate(string command)
        {
            if (!Command.listCommand.Contains(command.ToLower()))
            {
                throw new InvalidCommandException("Bad entry");
            }
        }
    }
}
