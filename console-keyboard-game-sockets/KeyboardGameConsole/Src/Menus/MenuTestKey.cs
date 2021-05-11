using System;

using KeyboardGameConsole.Src.Print;
using KeyboardGameConsole.Src.Navbar;

namespace KeyboardGameConsole.Src.Menus
{
    internal class MenuTestKey
    {
        private MenuTestKey()
        {
        }

        internal static void ShowMenu()
        {
            string mainNav = NavigationBar.mainNavBar;
            string testNav = NavigationBar.testKeysNavBar;
            string runTestNav = NavigationBar.runTestNavBar;
            ConsoleKeyInfo cki;
            string inputKey;
            bool band;
            do
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine($"{ mainNav }>>{ testNav }>>{ runTestNav }>>");
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Hit keyboard (Ctrl + Q) To return");
                cki = Console.ReadKey(true);
                inputKey = cki.Key.ToString();
                PrintTestKey.Print(inputKey);
                band = ((cki.Modifiers & ConsoleModifiers.Control) != 0) && (cki.Key == ConsoleKey.Q);
            } while (!band);
        }
    }
}
