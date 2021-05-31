using System.Collections.Generic;

namespace SensitiveInformationConsole.Src.Commands
{
    internal class Command
    {
        private Command()
        {
        }

        internal const string AGREGATE = "add";
        internal const string REMOVE = "remove";
        internal const string UPDATE = "update";
        internal const string LIST = "list";
        internal readonly static List<string> listCommand = new List<string>()
        {
            AGREGATE,
            REMOVE,
            UPDATE,
            LIST
        };
    }
}
