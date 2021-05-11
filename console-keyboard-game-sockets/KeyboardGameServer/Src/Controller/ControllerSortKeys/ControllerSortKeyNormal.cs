using KeyboardGameCore.Src.Container;
using KeyboardGameCore.Src.Order;
using KeyboardGameServer.Src.Response;
using System.Net.Sockets;

namespace KeyboardGameServer.Src.Controller.ControllerSortKeys
{
    internal class ControllerSortKeyNormal : IControllerSortKey
    {
        private ContainerList container = ContainerList.GetInstance();
        public void Sort(NetworkStream stream)
        {
            container.normalKeyboard = ToggleSort.Sort(container.normalKeyboard);
            ResponseServer.SendResponse(stream, "ToggleSort normal keys sucessfully");
        }
    }
}
