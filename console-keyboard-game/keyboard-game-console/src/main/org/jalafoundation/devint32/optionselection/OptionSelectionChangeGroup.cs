using System;
using System.Collections.Generic;

using keyboard_game_console.src.main.org.jalafoundation.devint32.menus;
using keyboard_game_console.src.main.org.jalafoundation.devint32.navbar;

using keyboard_game_core.src.main.org.jalafoundation.devint32.order;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.optionselection
{
    internal class OptionSelectionChangeGroup
    {
        private readonly static List<string> options = new List<string>() { "Normal", "Special", "Functional" };

        private OptionSelectionChangeGroup()
        {
        }

        internal static void Select()
        {
            int option;
            string mainNav = NavigationBar.mainNavBar;
            string settingsNav = NavigationBar.settingsNavBar;
            string keyboardNav = NavigationBar.keyboardNavBar;
            string changeGroupNav = NavigationBar.changeGroupNavBar;
            do
            {
                Console.Clear();
                Console.WriteLine($"{ mainNav }>>{ settingsNav }>>{ keyboardNav }>>{ changeGroupNav }");
                MenuChangeGroup.ShowMenu(options);
                switch (option = ReadOption())
                {
                    case 49:
                        Change(0, options);
                        break;
                    case 50:
                        Change(1, options);
                        break;
                    case 51:
                        Change(2, options);
                        break;
                    default:
                        Console.WriteLine("Return to Previous Menu.");
                        System.Threading.Thread.Sleep(500);
                        break;
                }
            } while (option == 49 || option == 50 || option == 51);
        }

        private static int ReadOption()
        {
            int key = Console.ReadKey(true).KeyChar;
            return key;
        }

        private static void Change(int position,List<string> options)
        {
            ChangeGroup.ChangePositionOptions(position, options);
            ChangeGroup.ChangePositionKeys(position);
        }
    }
}
