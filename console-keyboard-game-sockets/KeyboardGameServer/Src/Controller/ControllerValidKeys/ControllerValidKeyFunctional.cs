using KeyboardGameCore.Src.Keys;
using KeyboardGameServer.Src.Response;
using KeyboardGameUtils.Src;
using System.Net.Sockets;

namespace KeyboardGameServer.Src.Controller.ControllerValidKeys
{
    public class ControllerValidKeyFunctional : IControllerValidKey
    {
        public void GetValidKeys(NetworkStream stream)
        {
            var converted = ConvertListToString<string>.Convert(FunctionalKey.functionalKeyList);
            ResponseServer.SendResponse(stream, converted);
        }
    }
}
