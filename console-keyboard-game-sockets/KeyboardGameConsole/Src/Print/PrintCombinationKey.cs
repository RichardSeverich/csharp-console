using System;

using KeyboardGameClient.Src.Client;
using KeyboardGameConsole.Src.ResponseManager;
using KeyboardGameConsole.Src.ResponseManager.ResponseDict;
using KeyboardGameConsole.Src.ResponseManager.ResponseList;

namespace KeyboardGameConsole.Src.Print
{
    internal class PrintCombinationKey
    {
        private static AbstractFactory factoryList = ProductFactory.GetFactory("FactoryList");
        private static AbstractFactory factoryDict = ProductFactory.GetFactory("FactoryDict");

        private static IResponseList respListCombined = factoryList.GetRespList("ResponseCombinedKey");
        private static IResponseDict respDictSpecial = factoryDict.GetRespDict("ResponseSpecialKey");
        private static IResponseDict respDictNormal = factoryDict.GetRespDict("ResponseNormalKey");

        private PrintCombinationKey()
        {
        }

        internal static void Print(string modifier, string key)
        {
            if (respDictSpecial.GetResponse().ContainsKey(modifier) && respDictNormal.GetResponse().ContainsKey(key))
            {
                if (!respListCombined.GetResponse().Contains($"{ modifier }+{ key }"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(modifier);
                    Console.ResetColor();
                    Console.Write($"+{ key }");
                    ClientSocket.SendRequest($"{modifier}+{key}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{ modifier }+{ key }");
                    ClientSocket.SendRequest($"{modifier}+{key}");
                }
            }
            else
            {
                Console.WriteLine("Key not exist");
            }
        }
    }
}
