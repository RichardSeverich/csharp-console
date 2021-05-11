using KeyboardGameClient.Src.Client;
using KeyboardGameClient.Src.Response;
using KeyboardGameUtils.Src;
using System.Collections.Generic;

namespace KeyboardGameConsole.Src.ResponseManager.ResponseDict
{
    public class ResponseDictSpecialKey : IResponseDict
    {
        public Dictionary<string, int[]> GetResponse()
        {
            ClientSocket.SendRequest("GetSpecialKeys");
            return ConvertStringToDictionary<string, int[]>.Convert(ResponseClient.responseData);
        }
    }
}
