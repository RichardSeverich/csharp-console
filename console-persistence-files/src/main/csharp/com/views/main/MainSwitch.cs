using System;

using App.src.main.csharp.com.views.users;
using App.src.main.csharp.com.utils;

namespace App.src.main.csharp.com.views.main
{
    public class MainSwitch
    {
        private static string option;

        public static void show()
        {
            do
            {
                CleanConsole.clean();
                MainMenu.show();
                switch (option = Console.ReadLine())
                {
                    case "1":
                        UserSwich.show();
                        break;
                }
            } while (!option.Equals("2"));
        }
    }
}
