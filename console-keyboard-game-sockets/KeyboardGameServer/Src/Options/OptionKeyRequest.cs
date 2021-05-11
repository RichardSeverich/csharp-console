using System.Collections.Generic;

namespace KeyboardGameServer.Src.Options
{
    internal class OptionKeyRequest
    {
        internal const string KEY_NORMAL = "GetNormalKeys";
        internal const string KEY_FUNCTIONAL = "GetFunctionalKeys";
        internal const string KEY_SPECIAL = "GetSpecialKeys";
        internal const string KEY_COMBINED = "GetCombinedKeys";
        internal readonly static List<string> optionReqList = new List<string>()
        {
            KEY_NORMAL,
            KEY_FUNCTIONAL,
            KEY_SPECIAL,
            KEY_COMBINED
        };

        private OptionKeyRequest()
        {
        }
    }
}
