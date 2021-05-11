using System.Net.Sockets;

namespace KeyboardGameServer.Src.Controller.ControllerKeys
{
    interface IControllerKey
    {
        public void GetKeys(NetworkStream stream);
    }
}
