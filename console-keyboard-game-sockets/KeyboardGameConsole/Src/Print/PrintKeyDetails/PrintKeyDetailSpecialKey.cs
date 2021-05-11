using System;

using KeyboardGameConsole.Src.ResponseManager;
using KeyboardGameConsole.Src.ResponseManager.ResponseDict;

namespace KeyboardGameConsole.Src.Print.PrintKeyDetails
{
    internal class PrintKeyDetailSpecialKey : AbstractPrintKeyDetail, IPrint
    {
        public void Print()
        {
            AbstractFactory factoryDict = ProductFactory.GetFactory("FactoryDict");
            IResponseDict response = factoryDict.GetRespDict("ResponseSpecialKey");
            PrintDetails(response.GetResponse(), ConsoleColor.Green);
        }
    }
}
