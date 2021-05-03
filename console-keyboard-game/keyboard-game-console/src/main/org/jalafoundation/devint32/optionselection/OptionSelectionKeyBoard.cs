using System;

using keyboard_game_console.src.main.org.jalafoundation.devint32.menus;
using keyboard_game_console.src.main.org.jalafoundation.devint32.navbar;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.optionselection
{
    internal class OptionSelectionKeyBoard
    {
        private OptionSelectionKeyBoard()
        {
        }

        internal static void Select()
        {
            int option;
            string mainNav = NavigationBar.mainNavBar;
            string settingsNav = NavigationBar.settingsNavBar;
            string keyboardNav = NavigationBar.keyboardNavBar;
            do
            {
                Console.Clear();
                Console.WriteLine($"{ mainNav }>>{ settingsNav }>>{ keyboardNav }>>");
                MenuKeyboard.ShowMenu();
                switch (option = ReadOption())
                {
                    case 49:
                        OptionSelectionToggleSort.Select();
                        break;
                    case 50:
                        OptionSelectionChangeGroup.Select();
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
