using System.Collections.Generic;

namespace KeyboardGameServer.Src.Options
{
    internal class OptionValidKeyRequest
    {
        internal const string KEY_NORMAL_VALID = "GetNormalValidKeys";
        internal const string KEY_FUNCTIONAL_VALID = "GetFunctionalValidKeys";
        internal const string KEY_SPECIAL_VALID = "GetSpecialValidKeys";
        internal readonly static List<string> optionValidKeyList = new List<string>()
        {
            KEY_NORMAL_VALID,
            KEY_FUNCTIONAL_VALID,
            KEY_SPECIAL_VALID
        };

        private OptionValidKeyRequest()
        {
        }
    }
}
