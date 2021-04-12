using System;

using App.src.main.csharp.com.utils;

namespace App.src.main.csharp.com.views.users
{
    public class UserSwich
    {
        private static string option;

        private UserSwich()
        {
        }

        public static void show()
        {
            do
            {
                CleanConsole.clean();
                UserMenu.show();
                switch (option = Console.ReadLine())
                {
                    case "1":
                        UserRegister.show();
                        break;
                    case "2":
                        UserEdit.show();
                        break;
                    case "3":
                        UserDelete.show();
                        break;
                    case "4":
                        UserShow.show();
                        break;
                }
            } while (!option.Equals("5"));
        }
    }
}
