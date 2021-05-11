using System;
using System.Collections.Generic;

namespace KeyboardGameConsole.Src.Print
{
    public abstract class AbstractPrintKeyDetail
    {
        public void PrintDetails(Dictionary<string, int[]> keys, ConsoleColor color)
        {
            foreach (var key in keys)
            {
                Console.ForegroundColor = color;
                Console.Write($"{key.Key}");
                Console.ResetColor();
                Console.WriteLine($"\t\t{key.Value[0]}\t\t{key.Value[1]}");
            }
        }
    }
}
