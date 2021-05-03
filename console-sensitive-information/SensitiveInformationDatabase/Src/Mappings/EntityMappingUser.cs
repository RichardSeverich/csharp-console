using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationDatabase.Src.Utils;

namespace SensitiveInformationDatabase.Src.Mappings
{
    internal class EntityMappingUser : IEntityMapping<EntityUser>
    {
        public List<EntityUser> Map(SqlDataReader reader)
        {
            List<EntityUser> listUsers = new List<EntityUser>();
            Dictionary<string, string> columns = AnnotationsColumnName<EntitySensitiveInformation>.GetColumnsNames();

            while (reader.Read())
            {
                EntityUser user = new EntityUser();
                user.id = reader.GetInt32(columns["id"]);
                user.uuid = reader.GetString(columns["uuid"]);
                user.username = reader.GetString(columns["username"]);
                user.password = reader.GetString(columns["password"]);
                listUsers.Add(user);
            }

            return listUsers;
        }
    }
}
