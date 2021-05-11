using System;

using KeyboardGameConsole.Src.Menus;
using KeyboardGameConsole.Src.Navbar;

namespace KeyboardGameConsole.Src.OptionSelection
{
    internal class OptionSelectionSettings
    {
        private OptionSelectionSettings()
        {
        }

        internal static void Select()
        {
            int option;
            string mainNav = NavigationBar.mainNavBar;
            string settingsNav = NavigationBar.settingsNavBar;
            do
            {
                Console.Clear();
                Console.WriteLine($"{ mainNav }>>{ settingsNav }>>");
                MenuSettings.ShowMenu();
                switch (option = ReadOption())
                {
                    case 49:
                        OptionSelectionKeyBoard.Select();
                        break;
                    case 50:
                        OptionSelectionKey.Select();
                        break;
                    case 17:
                        Console.WriteLine("Returning to Main Menu.");
                        System.Threading.Thread.Sleep(500);
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        System.Threading.Thread.Sleep(500);
                        break;
                }
            } while (option != 17);
        }

        private static int ReadOption()
        {
            int key = Console.ReadKey(true).KeyChar;
            return key;
        }
    }
}
