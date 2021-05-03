using System;

using keyboard_game_core.src.main.org.jalafoundation.devint32.container;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.print
{
    internal class PrintKeyboard
    {
        private static ContainerList containerList = ContainerList.GetInstance();

        private PrintKeyboard()
        {
        }

        internal static void Print()
        {
            foreach (var key in containerList.keyboardlist)
            {
                if (containerList.normalKeys.Contains(key))
                {
                    Console.Write(key + " ");
                }
                else if (containerList.specialKeys.Contains(key))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(key + " ");
                }
                else if (containerList.functionalKeys.Contains(key))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(key + " ");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
