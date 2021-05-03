using System;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.menus
{
    internal class MenuSettings
    {
        private MenuSettings()
        {
        }

        internal static void ShowMenu()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("1.- Keyboard.");
            Console.WriteLine("2.- Keys.");
            Console.WriteLine("\n(Ctrl + Q) To return");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Select a option...");
        }
    }
}
