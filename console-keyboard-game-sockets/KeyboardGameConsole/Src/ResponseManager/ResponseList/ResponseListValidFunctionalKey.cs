using KeyboardGameClient.Src.Client;
using KeyboardGameClient.Src.Response;
using KeyboardGameUtils.Src;
using System.Collections.Generic;

namespace KeyboardGameConsole.Src.ResponseManager.ResponseList
{
    class ResponseListValidFunctionalKey : IResponseList
    {
        public List<string> GetResponse()
        {
            ClientSocket.SendRequest("GetFunctionalValidKeys");
            return ConvertStringToList<string>.Convert(ResponseClient.responseData);
        }
    }
}
