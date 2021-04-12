using System;

namespace App.src.main.csharp.com.views.users
{
    public class UserMenu
    {
        private UserMenu()
        {
        }

        public static void show()
        {
            Console.WriteLine("_____________________________");
            Console.WriteLine("         User Menu           ");
            Console.WriteLine("_____________________________");
            Console.WriteLine("1.- Register");
            Console.WriteLine("2.- Edit");
            Console.WriteLine("3.- Delete");
            Console.WriteLine("4.- Show");
            Console.WriteLine("5.- Return to Main Menu");
            Console.WriteLine("_____________________________");
            Console.WriteLine("");
            Console.WriteLine("Select a option");
        }
    }
}
