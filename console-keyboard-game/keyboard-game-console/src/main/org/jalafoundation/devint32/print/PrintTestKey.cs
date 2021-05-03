using System;

using keyboard_game_core.src.main.org.jalafoundation.devint32.container;
using keyboard_game_core.src.main.org.jalafoundation.devint32.utils;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.print
{
    internal class PrintTestKey
    {
        private static ContainerList container = ContainerList.GetInstance();

        private PrintTestKey()
        {
        }

        internal static void PrintInputNormalKeyTest(string inputKey)
        {
            if (FindKeyType.isNormal(inputKey))
            {
                Console.WriteLine(inputKey.ToLower());
                container.keyedCombined[inputKey.ToLower()][0] += 1;
                System.Threading.Thread.Sleep(1000);
            }
        }

        internal static void PrintInputFunctionalKeyTest(string inputKey)
        {
            if (FindKeyType.isFunctional(inputKey))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(inputKey.ToUpper());
                container.keyedCombined[inputKey.ToUpper()][0] += 1;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
