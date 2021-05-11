using KeyboardGameCore.Src.Keys;
using KeyboardGameServer.Src.Response;
using KeyboardGameUtils.Src;
using System.Net.Sockets;

namespace KeyboardGameServer.Src.Controller.ControllerValidKeys
{
    public class ControllerValidKeySpecial : IControllerValidKey
    {
        public void GetValidKeys(NetworkStream stream)
        {
            var converted = ConvertListToString<string>.Convert(SpecialKey.specialKeyList);
            ResponseServer.SendResponse(stream, converted);
        }
    }
}
