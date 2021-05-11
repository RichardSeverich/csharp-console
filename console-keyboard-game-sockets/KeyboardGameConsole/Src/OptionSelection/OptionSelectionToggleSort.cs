using System;

using KeyboardGameConsole.Src.Menus;
using KeyboardGameConsole.Src.Navbar;
using KeyboardGameConsole.Src.Print.PrintKeyboard;
using KeyboardGameClient.Src.Client;

namespace KeyboardGameConsole.Src.OptionSelection
{
    internal class OptionSelectionToggleSort
    {
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
                        Print("Normal");
                        break;
                    case 50:
                        Print("Special");
                        break;
                    case 51:
                        Print("Functional");
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

        private static void Print(string toggle)
        {
            Console.Clear();
            PrintKey.PrintKeyboard();
            ClientSocket.SendRequest(toggle);
            Console.WriteLine("\nTogglet to:");
            PrintKey.PrintKeyboard();
            Console.WriteLine("\n(Press any key to return to Main Menu)");
            Console.ReadKey(true);
        }
    }
}
