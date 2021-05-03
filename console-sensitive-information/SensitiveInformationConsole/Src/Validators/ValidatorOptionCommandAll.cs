using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationConsole.Src.Exceptions;

namespace SensitiveInformationConsole.Src.Validators
{
    internal class ValidatorOptionCommandAll
    {
        private ValidatorOptionCommandAll()
        {
        }

        internal static void Validate(string command)
        {
            if (!CommandOption.listCommandOption.Contains(command.ToLower()) &&
                !CommandOptionKey.listCommandOptionKey.Contains(command.ToLower()))
            {
                string commands = string.Join(", ", CommandOption.listCommandOption.ToArray());
                string commandKeys = string.Join(", ", CommandOptionKey.listCommandOptionKey.ToArray());
                throw new InvalidCommandException("Bad option command: " + commands + ", " + commandKeys);
            }
        }
    }
}
