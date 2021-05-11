using System;

using KeyboardGameConsole.Src.Navbar;
using KeyboardGameConsole.Src.Print;
using KeyboardGameConsole.Src.ResponseManager;
using KeyboardGameConsole.Src.ResponseManager.ResponseList;

namespace KeyboardGameConsole.Src.Menus
{
    internal class MenuKeyCombination
    {
        private static string modifier = "";
        private static AbstractFactory factoryList = ProductFactory.GetFactory("FactoryList");

        private static IResponseList respListSpecial = factoryList.GetRespList("ResponseValidSpecialKey");
        private static IResponseList respListNormal = factoryList.GetRespList("ResponseValidNormalKey");

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
                if (respListSpecial.GetResponse().Contains(modifier))
                {
                    if (respListNormal.GetResponse().Contains(inputKey.ToLower()))
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
