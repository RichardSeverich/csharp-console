using System.Collections.Generic;

namespace KeyboardGameCore.Src.Keys
{
    public class NormalKey
    {
        private const string A = "a";
        private const string B = "b";
        private const string C = "c";
        private const string D = "d";
        private const string E = "e";
        public readonly static List<string> normalKeyList = new List<string>()
        {
            A,
            B,
            C,
            D,
            E
        };

        private NormalKey()
        {
        }
    }
}
