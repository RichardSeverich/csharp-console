using KeyboardGameServer.Src.Options;

namespace KeyboardGameServer.Src.Controller.ControllerSortKeys
{
    public class ControllerSortKeyFactory
    {
        internal static IControllerSortKey GetControllerSort(string req)
        {
            switch (req)
            {
                case OptionToggleSort.TOGGLE_NORMAL:
                    return new ControllerSortKeyNormal();

                case OptionToggleSort.TOGGLE_SPECIAL:
                    return new ControllerSortKeySpecial();

                case OptionToggleSort.TOGGLE_FUNCTIONAL:
                    return new ControllerSortKeyFunctional();

                default:
                    return null;
            }
        }
    }
}
