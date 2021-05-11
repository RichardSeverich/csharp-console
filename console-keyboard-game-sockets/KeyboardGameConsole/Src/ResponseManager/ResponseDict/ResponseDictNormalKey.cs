using System.Collections.Generic;

using KeyboardGameClient.Src.Client;
using KeyboardGameClient.Src.Response;
using KeyboardGameUtils.Src;

namespace KeyboardGameConsole.Src.ResponseManager.ResponseDict
{
    public class ResponseDictNormalKey : IResponseDict
    {
        public Dictionary<string, int[]> GetResponse()
        {
            ClientSocket.SendRequest("GetNormalKeys");
            return ConvertStringToDictionary<string, int[]>.Convert(ResponseClient.responseData);
        }
    }
}
