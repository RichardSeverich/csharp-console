using KeyboardGameConsole.Src.ResponseManager.ResponseDict;
using System;

namespace KeyboardGameConsole.Src.ResponseManager.ResponseList
{
    public class ResponseListFactory : AbstractFactory
    {
        public IResponseList GetRespList(string resp)
        {
            switch (resp)
            {
                case "ResponseCombinedKey":
                    return new ResponseListCombinedKey();

                case "ResponseValidNormalKey":
                    return new ResponseListValidNormalKey();

                case "ResponseValidFunctionalKey":
                    return new ResponseListValidFunctionalKey();

                case "ResponseValidSpecialKey":
                    return new ResponseListValidSpecialKey();

                default:
                    return null;
            }
        }

        public IResponseDict GetRespDict(string resp)
        {
            return null;
        }
    }
}
