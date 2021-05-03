using System;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.menus
{
    internal class MenuKeyboard
    {
        private MenuKeyboard()
        {
        }

        internal static void ShowMenu()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("1.- Toggle Sort.");
            Console.WriteLine("2.- Change Groups Place.");
            Console.WriteLine("\n(Ctrl + Q) To return");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Select a option...");
        }
    }
}
