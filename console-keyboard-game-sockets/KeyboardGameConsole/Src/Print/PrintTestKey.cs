using System;

using KeyboardGameClient.Src.Client;
using KeyboardGameConsole.Src.ResponseManager;
using KeyboardGameConsole.Src.ResponseManager.ResponseDict;

namespace KeyboardGameConsole.Src.Print
{
    internal class PrintTestKey
    {
        private static AbstractFactory factoryDict = ProductFactory.GetFactory("FactoryDict");

        private static IResponseDict respDictNormal = factoryDict.GetRespDict("ResponseNormalKey");
        private static IResponseDict respDictSpecial = factoryDict.GetRespDict("ResponseSpecialKey");
        private static IResponseDict respDictFunctional = factoryDict.GetRespDict("ResponseFunctionalKey");

        private PrintTestKey()
        {
        }

        internal static void Print(string inputKey)
        {
            if (respDictNormal.GetResponse().ContainsKey(inputKey.ToLower()))
            {
                Console.WriteLine(inputKey.ToLower());
                ClientSocket.SendRequest(inputKey.ToLower());
            }
            else if (respDictSpecial.GetResponse().ContainsKey(inputKey))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(inputKey.ToLower());
                ClientSocket.SendRequest(inputKey.ToLower());
            }
            else if (respDictFunctional.GetResponse().ContainsKey(inputKey))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(inputKey);
                ClientSocket.SendRequest(inputKey);
            }
            System.Threading.Thread.Sleep(2000);
        }
    }
}
