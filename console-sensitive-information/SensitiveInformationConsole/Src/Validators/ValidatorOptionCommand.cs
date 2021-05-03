using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationConsole.Src.Exceptions;

namespace SensitiveInformationConsole.Src.Validators
{
    internal class ValidatorOptionCommand
    {
        private ValidatorOptionCommand()
        {
        }

        internal static void Validate(string command)
        {
            if (!CommandOption.listCommandOption.Contains(command.ToLower()))
            {
                string commands = string.Join(", ", CommandOption.listCommandOption.ToArray());
                throw new InvalidCommandException("Bad option command: " + commands);
            }
        }
    }
}
