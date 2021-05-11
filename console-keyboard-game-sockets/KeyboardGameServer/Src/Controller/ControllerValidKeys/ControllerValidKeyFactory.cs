using KeyboardGameServer.Src.Options;

namespace KeyboardGameServer.Src.Controller.ControllerValidKeys
{
    public class ControllerValidKeyFactory
    {
        internal static IControllerValidKey GetControllerValid(string req)
        {
            switch (req)
            {
                case OptionValidKeyRequest.KEY_NORMAL_VALID:
                    return new ControllerValidKeyNormal();

                case OptionValidKeyRequest.KEY_SPECIAL_VALID:
                    return new ControllerValidKeySpecial();

                case OptionValidKeyRequest.KEY_FUNCTIONAL_VALID:
                    return new ControllerValidKeyFunctional();

                default:
                    return null;
            }
        }
    }
}
