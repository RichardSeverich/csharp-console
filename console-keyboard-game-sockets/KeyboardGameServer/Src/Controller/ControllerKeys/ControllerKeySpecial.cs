using System.Net.Sockets;

using KeyboardGameCore.Src.Container;
using KeyboardGameServer.Src.Response;
using KeyboardGameUtils.Src;

namespace KeyboardGameServer.Src.Controller.ControllerKeys
{
    public class ControllerKeySpecial : IControllerKey
    {
        private ContainerList container = ContainerList.GetInstance();

        public void GetKeys(NetworkStream stream)
        {
            var converted = ConvertDictionaryToString<string, int[]>.Convert(container.specialKeyboard);
            ResponseServer.SendResponse(stream, converted);
        }
    }
}
