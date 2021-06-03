using System.Collections.Generic;

namespace SensitiveInformationConsole.Src.Commands
{
    internal class CommandOptionKey
    {
        internal const string SI_UUID = "-uuid";
        internal const string SI_ID = "-id";
        internal readonly static List<string> listCommandOptionKey = new List<string>()
        {
            SI_UUID,
            SI_ID
        };

        private CommandOptionKey()
        {
        }
    }
}
