using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationConsole.Src.Exceptions;

namespace SensitiveInformationConsole.Src.Validators
{
    internal class ValidatorOptionCommandKey
    {
        private ValidatorOptionCommandKey()
        {
        }

        internal static void Validate(string command)
        {
            if (!CommandOptionKey.listCommandOptionKey.Contains(command.ToLower()))
            {
                string commands = string.Join(", ", CommandOptionKey.listCommandOptionKey.ToArray());
                throw new InvalidCommandException("Bad option command: " + commands);
            }
        }
    }
}
