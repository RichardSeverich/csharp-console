using System;

using keyboard_game_core.src.main.org.jalafoundation.devint32.container;
using keyboard_game_core.src.main.org.jalafoundation.devint32.utils;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.print
{
    internal class PrintCombinationKey
    {
        private static ContainerList container = ContainerList.GetInstance();

        private PrintCombinationKey()
        {
        }

        internal static void Print(string modifier, string key)
        {
            if (!container.combinedKeys.Contains($"{ modifier }+{ key }"))
            {
                if (FindKeyType.isSpecial(modifier))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(modifier);
                Console.ResetColor();
                Console.Write($"+{ key }");
                container.combinedKeys.Add($"{ modifier }+{ key }");
                container.keyedCombined[key][1] += 1;
                container.keyedCombined[modifier][1] += 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{ modifier }+{ key }");
                container.combinedKeys.Remove($"{ modifier }+{ key }");
                container.keyedCombined[key][1] -= 1;
                container.keyedCombined[modifier][1] -= 1;
            }
        }
    }
}
