using KeyboardGameConsole.Src.ResponseManager;
using KeyboardGameConsole.Src.ResponseManager.ResponseDict;
using System;

namespace KeyboardGameConsole.Src.Print.PrintKeyboard
{
    public class PrintKeyboardNormalKey : AbstractPrintKeys, IPrint
    {
        public void Print()
        {
            AbstractFactory factoryDict = ProductFactory.GetFactory("FactoryDict");
            IResponseDict response = factoryDict.GetRespDict("ResponseNormalKey");
            PrintKeys(response.GetResponse(), ConsoleColor.White);
        }
    }
}
