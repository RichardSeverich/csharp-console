using System;

namespace SensitiveInformationCore.Src.Main.Models
{
    public class ModelUser
    {
        public int id;
        public string uuid;
        public string username;
        public string password;

        public override bool Equals(object obj)
        {
            ModelUser mobj = obj as ModelUser;

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
