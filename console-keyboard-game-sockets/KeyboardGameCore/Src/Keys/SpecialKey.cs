using System.Collections.Generic;

namespace KeyboardGameCore.Src.Keys
{
    public class SpecialKey
    {
        private const string ALT = "alt";
        private const string CTRL = "ctrl";
        private const string SHIFT = "shift";
        public readonly static List<string> specialKeyList = new List<string>()
        {
            ALT,
            CTRL,
            SHIFT
        };

        private SpecialKey()
        {
        }
    }
}
