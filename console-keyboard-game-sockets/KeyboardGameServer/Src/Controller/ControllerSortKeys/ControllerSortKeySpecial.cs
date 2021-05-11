using System.Net.Sockets;

using KeyboardGameCore.Src.Order;
using KeyboardGameServer.Src.Response;
using KeyboardGameCore.Src.Container;

namespace KeyboardGameServer.Src.Controller.ControllerSortKeys
{
    internal class ControllerSortKeySpecial : IControllerSortKey
    {
        private ContainerList container = ContainerList.GetInstance();

        public void Sort(NetworkStream stream)
        {
            container.specialKeyboard = ToggleSort.Sort(container.specialKeyboard);
            ResponseServer.SendResponse(stream, "ToggleSort special keys sucessfully");
        }
    }
}
