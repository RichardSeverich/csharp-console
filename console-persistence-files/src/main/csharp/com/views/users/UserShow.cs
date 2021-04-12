using System;

using App.src.main.csharp.com.containers;
using App.src.main.csharp.com.persistence;
using App.src.main.csharp.com.models.users;
using App.src.main.csharp.com.utils;

namespace App.src.main.csharp.com.views.users
{
    public class UserShow
    {
        //private static ListContainer listContainer = ListContainer.getInstance();

        private UserShow()
        {
        }

        public static void show()
        {
            CleanConsole.clean();
            Console.WriteLine("_____________________________");
            Console.WriteLine("          USER SHOW          ");
            Console.WriteLine("_____________________________");
            //Persistence<User>.read();
            foreach (var user in Persistence<User>.read())
            {
                Console.WriteLine("*                           *");
                Console.WriteLine("            USER             ");
                Console.WriteLine($"Uuid: {user.uuid}");
                Console.WriteLine($"Username: {user.userName}");
                Console.WriteLine($"Password: {user.password}");
                Console.WriteLine("_____________________________");
            }
            Console.Write("Press Enter To continue");
            Console.ReadLine();
        }
    }
}
