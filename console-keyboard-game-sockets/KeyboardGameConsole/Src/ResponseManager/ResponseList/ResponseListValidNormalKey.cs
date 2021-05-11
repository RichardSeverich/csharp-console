using KeyboardGameClient.Src.Client;
using KeyboardGameClient.Src.Response;
using KeyboardGameUtils.Src;
using System.Collections.Generic;

namespace KeyboardGameConsole.Src.ResponseManager.ResponseList
{
    class ResponseListValidNormalKey : IResponseList
    {
        public List<string> GetResponse()
        {
            ClientSocket.SendRequest("GetNormalValidKeys");
            return ConvertStringToList<string>.Convert(ResponseClient.responseData);
        }
    }
}
