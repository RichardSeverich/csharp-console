using KeyboardGameClient.Src.Client;
using KeyboardGameClient.Src.Response;
using KeyboardGameUtils.Src;
using System.Collections.Generic;

namespace KeyboardGameConsole.Src.ResponseManager.ResponseDict
{
    public class ResponseDictFunctionalKey : IResponseDict
    {
        public Dictionary<string, int[]> GetResponse()
        {
            ClientSocket.SendRequest("GetFunctionalKeys");
            return ConvertStringToDictionary<string, int[]>.Convert(ResponseClient.responseData);
        }
    }
}
