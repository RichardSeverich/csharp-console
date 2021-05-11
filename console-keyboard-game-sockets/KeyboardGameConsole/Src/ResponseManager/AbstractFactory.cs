using KeyboardGameConsole.Src.ResponseManager.ResponseDict;
using KeyboardGameConsole.Src.ResponseManager.ResponseList;

namespace KeyboardGameConsole.Src.ResponseManager
{
    public interface AbstractFactory
    {
        IResponseList GetRespList(string resp);

        IResponseDict GetRespDict(string resp);
    }
}
