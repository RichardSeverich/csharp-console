using System;

namespace KeyboardGameConsole.Src.Menus
{
    internal class MenuMain
    {
        private MenuMain()
        {
        }

        internal static void ShowMenu()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("1.- Show keyboard.");
            Console.WriteLine("2.- Show key Details.");
            Console.WriteLine("3.- Settings.");
            Console.WriteLine("4.- Test Keys.");
            Console.WriteLine("\n(Ctrl + Q) Quit");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Select a option...");
        }
    }
}
