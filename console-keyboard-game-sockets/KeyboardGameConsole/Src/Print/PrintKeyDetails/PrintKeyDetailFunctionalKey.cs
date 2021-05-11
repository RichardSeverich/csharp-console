using System;

using KeyboardGameConsole.Src.ResponseManager;
using KeyboardGameConsole.Src.ResponseManager.ResponseDict;

namespace KeyboardGameConsole.Src.Print.PrintKeyDetails
{
    internal class PrintKeyDetailFunctionalKey : AbstractPrintKeyDetail, IPrint
    {
        public void Print()
        {
            AbstractFactory factoryDict = ProductFactory.GetFactory("FactoryDict");
            IResponseDict response = factoryDict.GetRespDict("ResponseFunctionalKey");
            PrintDetails(response.GetResponse(), ConsoleColor.Blue);
        }
    }
}
