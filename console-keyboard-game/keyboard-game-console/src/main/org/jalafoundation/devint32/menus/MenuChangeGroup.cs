using System;
using System.Collections.Generic;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.menus
{
    internal class MenuChangeGroup
    {
        private MenuChangeGroup()
        {
        }

        internal static List<string> ShowMenu(List<string> options)
        {
            Console.WriteLine("_____________________________________");
            for (int i = 0; i < options.Count; i++)
            {
                Console.Write($"\n {i + 1}) {options[i]} Key.");
            }
            Console.WriteLine("\n_____________________________________");
            Console.WriteLine("\n(Press any key to return)");
            return options;
        }
    }
}
