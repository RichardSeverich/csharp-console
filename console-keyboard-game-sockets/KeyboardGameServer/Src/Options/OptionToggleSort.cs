using System.Collections.Generic;

namespace KeyboardGameServer.Src.Options
{
    internal class OptionToggleSort
    {
        internal const string TOGGLE_NORMAL = "Normal";
        internal const string TOGGLE_FUNCTIONAL = "Functional";
        internal const string TOGGLE_SPECIAL = "Special";
        internal readonly static List<string> optionToggleList = new List<string>()
        {
            TOGGLE_NORMAL,
            TOGGLE_FUNCTIONAL,
            TOGGLE_SPECIAL
        };

        private OptionToggleSort()
        {
        }
    }
}
