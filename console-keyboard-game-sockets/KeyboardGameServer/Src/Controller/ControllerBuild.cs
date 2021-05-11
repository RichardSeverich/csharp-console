using KeyboardGameCore.Src.Builders;
using KeyboardGameServer.Src.Response;
using KeyboardGameUtils.Src;
using System.Net.Sockets;
using System.Collections.Generic;

namespace KeyboardGameServer.Src.Controller
{
    internal class ControllerBuild
    {
        private ControllerBuild()
        {
        }

        public static void Build(NetworkStream stream, string jsonList)
        {
            List<string> initKeys = ConvertStringToList<string>.Convert(jsonList.Normalize());
            BuilderKey.Build(initKeys);
            ResponseServer.SendResponse(stream, "Build Keys Succesfully");
        }
    }
}
