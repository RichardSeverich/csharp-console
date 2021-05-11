using System.Net.Sockets;

using KeyboardGameCore.Src.Container;
using KeyboardGameServer.Src.Response;
using KeyboardGameUtils.Src;

namespace KeyboardGameServer.Src.Controller.ControllerKeys
{
    public class ControllerKeyCombined : IControllerKey
    {
        private ContainerList container = ContainerList.GetInstance();
        public void GetKeys(NetworkStream stream)
        {
            var converted = ConvertListToString<string>.Convert(container.combinedKeys);
            ResponseServer.SendResponse(stream, converted);
        }
    }
}
