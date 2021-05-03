using System;

using keyboard_game_console.src.main.org.jalafoundation.devint32.navbar;
using keyboard_game_console.src.main.org.jalafoundation.devint32.print;

using keyboard_game_core.src.main.org.jalafoundation.devint32.utils;
using keyboard_game_core.src.main.org.jalafoundation.devint32.container;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.menus
{
    internal class MenuKeyCombination
    {
        private static ContainerList container = ContainerList.GetInstance();
        private static string modifier = "";

        private MenuKeyCombination()
        {
        }

        internal static void ShowMenu()
        {
            string mainNav = NavigationBar.mainNavBar;
            string settingsNav = NavigationBar.settingsNavBar;
            string keyNav = NavigationBar.keysNavBar;
            string combineNav = NavigationBar.combineKeysNavBar;
            string runCombineNav = NavigationBar.runCombineNavBar;
            ConsoleKeyInfo cki;
            string inputKey;
            bool band;
            do
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine($"{ mainNav }>>{ settingsNav }>>{ keyNav }>>{ combineNav }>>{ runCombineNav }>>");
                Console.WriteLine("_____________________________________");
                Console.WriteLine("\nHit Keyboard (Ctrl+Q to Quit)");
                cki = Console.ReadKey(true);
                SetModifier(cki);
                inputKey = cki.Key.ToString();
                if (FindKeyType.isSpecial(modifier))
                {
                    if (FindKeyType.isNormal(inputKey.ToLower()))
                    {
                        PrintCombinationKey.Print(modifier, inputKey.ToLower());
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                modifier = "";
                band = ((cki.Modifiers & ConsoleModifiers.Control) != 0) && (cki.Key == ConsoleKey.Q);
            }
            while (!band);
        }

        private static void SetModifier(ConsoleKeyInfo consoleKeyInfo)
        {
            if ((consoleKeyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
            {
                modifier = "alt";
            }
            if ((consoleKeyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
            {
                modifier = "shift";
            }
            if ((consoleKeyInfo.Modifiers & ConsoleModifiers.Control) != 0)
            {
                modifier = "ctrl";
            }
        }
    }
}
