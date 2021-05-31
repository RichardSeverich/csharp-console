using System;

namespace SensitiveInformationCore.Src.Main.EntityDomain
{
    public class User
    {
        public int id;
        public string uuid;
        public string username;
        public string password;

        public override bool Equals(object obj)
        {
            User mobj = obj as User;

            return mobj != null && id== mobj.id 
                && uuid.Equals(mobj.uuid) 
                && username.Equals(mobj.username) 
                && password.Equals(mobj.password);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, uuid, username, password);
        }
    }
}
