using System;

using App.src.main.csharp.com.containers;
using App.src.main.csharp.com.controllers;
using App.src.main.csharp.com.models.users;
using App.src.main.csharp.com.utils;
using App.src.main.csharp.com.security;

namespace App.src.main.csharp.com.views.users
{
    class UserEdit
    {
        private static ListContainer listContainer = ListContainer.getInstance();
        private UserEdit()
        {
        }

        public static void show()
        {
            CleanConsole.clean();
            Console.WriteLine("_____________________________");
            Console.WriteLine("          USER EDIT          ");
            Console.WriteLine("_____________________________");
            Console.WriteLine("Enter New Username: ");
            User user = new User();
            user.userName = Console.ReadLine();
            Console.WriteLine("_____________________________");
            Console.WriteLine("Enter New Password: ");
            user.password = Console.ReadLine();
            Console.WriteLine("_____________________________");
            Console.WriteLine("Enter User id: ");
            string uuid = Console.ReadLine();
            valid(user, uuid);
            Console.Write("\nPress Enter To continue");
            Console.ReadLine();
        }

        private static void valid(User user, string uuid)
        {
            if (ValidateUser.valid(user))
            {
                HandleEdit<User>.action(listContainer.userList, uuid, user);
                Console.Write("Edited");
            }
            else
            {
                Console.Write("Error a espace is empty");
            }
        }
    }
}
