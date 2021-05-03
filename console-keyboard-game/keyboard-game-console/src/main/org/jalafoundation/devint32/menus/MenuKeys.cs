using System;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.menus
{
    internal class MenuKeys
    {
        private MenuKeys()
        {
        }

        internal static void ShowMenu()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("1.- Combine keys.");
            Console.WriteLine("\n(Ctrl + Q) To return");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Select a option...");
        }
    }
}
