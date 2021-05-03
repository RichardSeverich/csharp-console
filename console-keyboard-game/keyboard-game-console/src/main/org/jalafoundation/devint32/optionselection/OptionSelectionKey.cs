using System;

using keyboard_game_console.src.main.org.jalafoundation.devint32.menus;
using keyboard_game_console.src.main.org.jalafoundation.devint32.navbar;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.optionselection
{
    internal class OptionSelectionKey
    {
        private OptionSelectionKey()
        {
        }

        internal static void Select()
        {
            int option;
            string mainNav = NavigationBar.mainNavBar;
            string settingsNav = NavigationBar.settingsNavBar;
            string keyNav = NavigationBar.keysNavBar;
            do
            {
                Console.Clear();
                Console.WriteLine($"{ mainNav }>>{ settingsNav }>>{ keyNav }>>");
                MenuKeys.ShowMenu();
                switch (option = ReadOption())
                {
                    case 49:
                        MenuKeyCombination.ShowMenu();
                        break;
                    case 17:
                        Console.WriteLine("Returning to Previous Menu.");
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
