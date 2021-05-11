using System.Collections.Generic;

namespace KeyboardGameCore.Src.Keys
{
    public class FunctionalKey
    {
        private const string F1 = "F1";
        private const string F2 = "F2";
        private const string F3 = "F3";
        private const string F4 = "F4";
        private const string F5 = "F5";
        public readonly static List<string> functionalKeyList = new List<string>()
        {
            F1,
            F2,
            F3,
            F4,
            F5
        };

        private FunctionalKey()
        {
        }
    }
}
