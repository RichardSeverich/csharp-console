using KeyboardGameCore.Src.Keys;
using KeyboardGameServer.Src.Response;
using KeyboardGameUtils.Src;
using System.Net.Sockets;

namespace KeyboardGameServer.Src.Controller.ControllerValidKeys
{
    class ControllerValidKeyNormal : IControllerValidKey
    {
        public void GetValidKeys(NetworkStream stream)
        {
            var converted = ConvertListToString<string>.Convert(NormalKey.normalKeyList);
            ResponseServer.SendResponse(stream, converted);
        }
    }
}
