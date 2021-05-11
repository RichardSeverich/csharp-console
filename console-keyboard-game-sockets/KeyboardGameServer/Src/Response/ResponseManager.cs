using System.Net.Sockets;

using KeyboardGameServer.Src.Controller;
using KeyboardGameServer.Src.Controller.ControllerKeys;
using KeyboardGameServer.Src.Controller.ControllerSortKeys;
using KeyboardGameServer.Src.Controller.ControllerValidKeys;
using KeyboardGameServer.Src.Options;

namespace KeyboardGameServer.Src.Response
{
    internal class ResponseManager
    {
        private ResponseManager()
        {
        }

        internal static void GetResponse(NetworkStream stream, string req)
        {
            if (OptionKeyRequest.optionReqList.Contains(req))
            {
                IControllerKey controllerKey = ControllerKeyFactory.GetController(req);
                controllerKey.GetKeys(stream);
            }
            else if (OptionValidKeyRequest.optionValidKeyList.Contains(req))
            {
                IControllerValidKey controllerValidKey = ControllerValidKeyFactory.GetControllerValid(req);
                controllerValidKey.GetValidKeys(stream);
            }
            else if (req.Contains("Build"))
            {
                ControllerBuild.Build(stream, req.Substring(6));
            }
            else if (OptionToggleSort.optionToggleList.Contains(req))
            {
                IControllerSortKey controllerSort = ControllerSortKeyFactory.GetControllerSort(req);
                controllerSort.Sort(stream);
            }
            else
            {
                ControllerPressedKey.Press(stream, req);
            }
        }
    }
}
