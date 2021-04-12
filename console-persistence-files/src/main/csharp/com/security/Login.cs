using App.src.main.csharp.com.containers;

namespace App.src.main.csharp.com.security
{
    public class Login
    {
        private static ListContainer listContainer = ListContainer.getInstance();

        private Login()
        {
        }

        public static bool valid(string username, string password)
        {
            foreach (var user in listContainer.userList)
            {
                if(user.userName.Equals(username) && user.password.Equals(password)){
                    return true;
                }
            }
            return false;
        }
    }
}
