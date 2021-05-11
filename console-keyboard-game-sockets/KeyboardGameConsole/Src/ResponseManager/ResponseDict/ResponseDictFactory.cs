using KeyboardGameConsole.Src.ResponseManager.ResponseList;

namespace KeyboardGameConsole.Src.ResponseManager.ResponseDict
{
    internal class ResponseDictFactory : AbstractFactory
    {
        public IResponseDict GetRespDict(string resp)
        {
            switch (resp)
            {
                case "ResponseNormalKey":
                    return new ResponseDictNormalKey();

                case "ResponseSpecialKey":
                    return new ResponseDictSpecialKey();

                case "ResponseFunctionalKey":
                    return new ResponseDictFunctionalKey();

                default:
                    return null;
            }
        }

        public IResponseList GetRespList(string resp)
        {
            return null;
        }
    }
}
