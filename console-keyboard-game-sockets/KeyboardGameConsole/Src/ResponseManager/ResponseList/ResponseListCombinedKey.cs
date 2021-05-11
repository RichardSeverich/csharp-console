using KeyboardGameClient.Src.Client;
using KeyboardGameClient.Src.Response;
using KeyboardGameUtils.Src;
using System.Collections.Generic;

namespace KeyboardGameConsole.Src.ResponseManager.ResponseList
{
    public class ResponseListCombinedKey : IResponseList
    {
        public List<string> GetResponse()
        {
            ClientSocket.SendRequest("GetCombinedKeys");
            return ConvertStringToList<string>.Convert(ResponseClient.responseData);
        }
    }
}
