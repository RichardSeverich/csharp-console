using System.Collections.Generic;

using App.src.main.csharp.com.models.users;

namespace App.src.main.csharp.com.containers
{
    public class ListContainer
    {
        private static ListContainer instance;
        public List<User> userList;

        private ListContainer()
        {
            userList = new List<User>();
        }

        public static ListContainer getInstance()
        {
            return (instance == null) ? instance = new ListContainer() : instance;
        }
    }
}
