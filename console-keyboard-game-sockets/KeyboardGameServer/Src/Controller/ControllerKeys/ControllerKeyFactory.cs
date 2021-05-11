using KeyboardGameServer.Src.Options;

namespace KeyboardGameServer.Src.Controller.ControllerKeys
{
    public class ControllerKeyFactory
    {
        internal static IControllerKey GetController(string req)
        {
            switch (req)
            {
                case OptionKeyRequest.KEY_NORMAL:
                    return new ControllerKeyNormal();

                case OptionKeyRequest.KEY_SPECIAL:
                    return new ControllerKeySpecial();

                case OptionKeyRequest.KEY_FUNCTIONAL:
                    return new ControllerKeyFunctional();

                case OptionKeyRequest.KEY_COMBINED:
                    return new ControllerKeyCombined();

                default:
                    return null;
            }
        }
    }
}
