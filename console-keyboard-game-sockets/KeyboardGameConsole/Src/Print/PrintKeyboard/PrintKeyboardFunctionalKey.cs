using System;
using KeyboardGameConsole.Src.ResponseManager;
using KeyboardGameConsole.Src.ResponseManager.ResponseDict;

namespace KeyboardGameConsole.Src.Print.PrintKeyboard
{
    public class PrintKeyboardFunctionalKey : AbstractPrintKeys, IPrint
    {
        public void Print()
        {
            AbstractFactory factoryDict = ProductFactory.GetFactory("FactoryDict");
            IResponseDict response = factoryDict.GetRespDict("ResponseFunctionalKey");
            PrintKeys(response.GetResponse(), ConsoleColor.Blue);
        }
    }
}
