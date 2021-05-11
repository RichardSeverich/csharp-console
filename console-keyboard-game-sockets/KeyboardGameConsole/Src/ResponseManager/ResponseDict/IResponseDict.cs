using System.Collections.Generic;

namespace KeyboardGameConsole.Src.ResponseManager.ResponseDict
{
    public interface IResponseDict
    {
        public Dictionary<string, int[]> GetResponse();
    }
}
