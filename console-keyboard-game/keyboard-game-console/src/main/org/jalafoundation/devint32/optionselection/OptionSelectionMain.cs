using System;

using keyboard_game_console.src.main.org.jalafoundation.devint32.menus;
using keyboard_game_console.src.main.org.jalafoundation.devint32.navbar;
using keyboard_game_console.src.main.org.jalafoundation.devint32.print;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.optionselection
{
    internal class OptionSelectionMain
    {
        private OptionSelectionMain()
        {
        }

        internal static void Select()
        {
            int option;
            string mainNav= NavigationBar.mainNavBar;
            do
            {
                Console.Clear();
                Console.WriteLine($">>{ mainNav }");
                MenuMain.ShowMenu();
                switch (option = ReadOption())
                {
                    case 49:
                        PrintKeys();
                        break;
                    case 50:
                        PrintKeyDetails.ShowDetails();
                        break;
                    case 51:
                        OptionSelectionSettings.Select();
                        break;
                    case 52:
                        MenuTestKey.ShowMenu();
                        break;
                    case 17:
                        Console.WriteLine("Exit to keyboard game.");
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

        private static void PrintKeys()
        {
            Console.Clear();
            PrintKeyboard.Print();
            Console.WriteLine("\n(Press any key to return to Main Menu)");
            Console.ReadKey(true);
        }
    }
}
