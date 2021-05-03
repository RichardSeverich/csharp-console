using System.Collections.Generic;

using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationDatabase.Src.Mappings;
using SensitiveInformationDatabase.Src.SqlCommands;
using SensitiveInformationDatabase.Src.Utils;
using SensitiveInformationDatabase.Src.BuildersColumnsValues;

namespace SensitiveInformationDatabase.Src.CrudManagers
{
    public class CrudManagerUser
    {
        private static string tableName = AnnotationsTableName<EntityUser>.GetTableName();

        public static void Create(EntityUser user)
        {
            string columns = BuilderColumnsAndValuesUser.GetColumnsToCreate();
            string values = BuilderColumnsAndValuesUser.GetValuesToCreate(user);
            SqlCommandInsert.Execute(tableName, columns.ToString(), values.ToString());
        }

        public static List<EntityUser> Read()
        {
            EntityMappingUser entityMappingUser = new EntityMappingUser();

            return SqlCommandSelect<EntityUser>.Execute(tableName, entityMappingUser);
        }

        public static void Update(int id, EntityUser user)
        {
            string columnsAndValues = BuilderColumnsAndValuesUser.GetValuesAndColumnsToUpdate(user);
            SqlCommandUpdateById.Execute(tableName, id, columnsAndValues.ToString());
        }

        public static void Delete(int id)
        {
            SqlCommandDeleteById.Execute(tableName, id);
        }
    }
}
