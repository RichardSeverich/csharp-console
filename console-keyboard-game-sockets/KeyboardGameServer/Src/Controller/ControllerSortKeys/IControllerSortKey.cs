using System.Net.Sockets;

namespace KeyboardGameServer.Src.Controller.ControllerSortKeys
{
    public interface IControllerSortKey
    {
        public void Sort(NetworkStream stream);
    }
}
