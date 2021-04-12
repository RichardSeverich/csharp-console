using System;

namespace App.src.main.csharp.com.models.users
{
    [Serializable]
    public class User : AbstractModel
    {
        public string userName;
        public string password;

        public User()
        {
            this.uuid = Guid.NewGuid().ToString();
        }
    }
}
