using System.Net.Sockets;

namespace KeyboardGameServer.Src.Controller.ControllerValidKeys
{
    public interface IControllerValidKey
    {
        public void GetValidKeys(NetworkStream stream);
    }
}
