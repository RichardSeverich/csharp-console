using App.src.main.csharp.com.models.users;

namespace App.src.main.csharp.com.security
{
    public class ValidateUser
    {
        private ValidateUser()
        {
        }

        public static bool valid(User user)
        {
            return (user.userName.Equals(string.Empty)) ? false :
                   (user.password.Equals(string.Empty)) ? false :
                                                          true;
        }
    }
}
