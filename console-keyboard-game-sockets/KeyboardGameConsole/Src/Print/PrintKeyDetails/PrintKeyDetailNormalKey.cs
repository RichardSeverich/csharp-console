using System;

using KeyboardGameConsole.Src.ResponseManager;
using KeyboardGameConsole.Src.ResponseManager.ResponseDict;

namespace KeyboardGameConsole.Src.Print.PrintKeyDetails
{
    internal class PrintKeyDetailNormalKey : AbstractPrintKeyDetail, IPrint
    {
        public void Print()
        {
            AbstractFactory factoryDict = ProductFactory.GetFactory("FactoryDict");
            IResponseDict response = factoryDict.GetRespDict("ResponseNormalKey");
            PrintDetails(response.GetResponse(), ConsoleColor.White);
        }
    }
}
