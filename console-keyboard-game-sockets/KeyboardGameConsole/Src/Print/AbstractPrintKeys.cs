using System;
using System.Collections.Generic;

namespace KeyboardGameConsole.Src.Print
{
    public abstract class AbstractPrintKeys
    {
        public void PrintKeys(Dictionary<string, int[]> keys, ConsoleColor color)
        {
            foreach (var key in keys)
            {
                Console.ForegroundColor = color;
                Console.Write($"{key.Key} ");
                Console.ResetColor();
            }
        }
    }
}
