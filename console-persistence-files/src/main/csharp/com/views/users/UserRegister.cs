using System;

using App.src.main.csharp.com.containers;
using App.src.main.csharp.com.controllers;
using App.src.main.csharp.com.models.users;
using App.src.main.csharp.com.security;
using App.src.main.csharp.com.utils;

namespace App.src.main.csharp.com.views.users
{
    public class UserRegister
    {
        private static ListContainer listContainer = ListContainer.getInstance();

        private UserRegister()
        {
        }

        public static void show()
        {
            CleanConsole.clean();
            Console.WriteLine("_____________________________");
            Console.WriteLine("        USER REGISTER        ");
            Console.WriteLine("_____________________________");
            User user = new User();
            Console.WriteLine("Username: ");
            user.userName = Console.ReadLine();
            Console.WriteLine("_____________________________");
            Console.WriteLine("Password: ");
            user.password = Console.ReadLine();
            Console.WriteLine("_____________________________");
            valid(user);
            Console.Write("\nPress Enter To continue");
            Console.ReadLine();
        }

        private static void valid(User user)
        {
            if (ValidateUser.valid(user))
            {
                HandleAdd<User>.action(listContainer.userList, user);
                Console.Write("Register");
            }
            else
            {
                Console.Write("Error a espace is empty");
            }
        }
    }
}
