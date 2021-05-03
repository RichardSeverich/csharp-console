using System;
using System.Collections.Generic;

using keyboard_game_console.src.main.org.jalafoundation.devint32.menus;
using keyboard_game_console.src.main.org.jalafoundation.devint32.navbar;
using keyboard_game_console.src.main.org.jalafoundation.devint32.print;

using keyboard_game_core.src.main.org.jalafoundation.devint32.order;
using keyboard_game_core.src.main.org.jalafoundation.devint32.container;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.optionselection
{
    internal class OptionSelectionToggleSort
    {
        private static ContainerList container = ContainerList.GetInstance();

        private OptionSelectionToggleSort()
        {
        }

        internal static void Select()
        {
            int option;
            string mainNav = NavigationBar.mainNavBar;
            string settingsNav = NavigationBar.settingsNavBar;
            string keyboardNav = NavigationBar.keyboardNavBar;
            string toggleNav = NavigationBar.toggleSortNavBar;
            do
            {
                Console.Clear();
                Console.WriteLine($"{ mainNav }>>{ settingsNav }>>{ keyboardNav }>>{ toggleNav }");
                MenuToggleSort.ShowMenu();
                switch (option = ReadOption())
                {
                    case 49:
                        PrintBeforeAfter(container.normalKeys, container.keyboardlist);
                        break;
                    case 50:
                        PrintBeforeAfter(container.specialKeys, container.keyboardlist);
                        break;
                    case 51:
                        PrintBeforeAfter(container.functionalKeys, container.keyboardlist);
                        break;
                    case 17:
                        Console.WriteLine("Returning to Previous Menu.");
                        System.Threading.Thread.Sleep(500);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
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

        private static void PrintBeforeAfter(List<string> Togglekeys, List<string> keyboardList)
        {
            Console.Clear();
            PrintKeyboard.Print();
            Console.WriteLine("\nTogglet to:");
            ToggleSort.Sort(Togglekeys, keyboardList);
            PrintKeyboard.Print();
            Console.WriteLine("\n(Press any key to return to Main Menu)");
            Console.ReadKey(true);
        }
    }
}
