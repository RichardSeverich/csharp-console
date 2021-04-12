using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.src.main.csharp.com.containers;
using App.src.main.csharp.com.controllers;
using App.src.main.csharp.com.models.users;
using App.src.main.csharp.com.utils;

namespace App.src.main.csharp.com.views.users
{
    public class UserDelete
    {
        private static ListContainer listContainer = ListContainer.getInstance();
        private UserDelete()
        {
        }

        public static void show()
        {
            CleanConsole.clean();
            Console.WriteLine("_____________________________");
            Console.WriteLine("         USER DELETE         ");
            Console.WriteLine("_____________________________");
            Console.WriteLine("Enter User id: ");
            string uuid = Console.ReadLine();
            HandleDelete<User>.action(listContainer.userList, uuid);
        } 
    }
}
