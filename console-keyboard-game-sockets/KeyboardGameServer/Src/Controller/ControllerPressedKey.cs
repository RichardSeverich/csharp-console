using KeyboardGameCore.Src.PressKey;
using KeyboardGameServer.Src.Response;
using System.Net.Sockets;

namespace KeyboardGameServer.Src.Controller
{
    internal class ControllerPressedKey
    {
        private ControllerPressedKey()
        {
        }

        internal static void Press(NetworkStream stream, string key)
        {
            PressKeyTest.Pressed(key);
            PressKeyCombination.Pressed(key);
            ResponseServer.SendResponse(stream, "Key is Pressed");
        }
    }
}
