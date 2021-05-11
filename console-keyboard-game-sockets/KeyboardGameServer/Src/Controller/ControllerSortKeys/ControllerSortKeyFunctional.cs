using KeyboardGameCore.Src.Container;
using KeyboardGameCore.Src.Order;
using KeyboardGameServer.Src.Response;
using System.Net.Sockets;

namespace KeyboardGameServer.Src.Controller.ControllerSortKeys
{
    internal class ControllerSortKeyFunctional : IControllerSortKey
    {
        private ContainerList container = ContainerList.GetInstance();
        public void Sort(NetworkStream stream)
        {
            container.functionalKeyboard = ToggleSort.Sort(container.functionalKeyboard);
            ResponseServer.SendResponse(stream, "ToggleSort functional keys sucessfully");
        }
    }
}
