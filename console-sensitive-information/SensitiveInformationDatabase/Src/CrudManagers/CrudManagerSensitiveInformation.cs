using System.Collections.Generic;

using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationDatabase.Src.Mappings;
using SensitiveInformationDatabase.Src.SqlCommands;
using SensitiveInformationDatabase.Src.Utils;
using SensitiveInformationDatabase.Src.BuildersColumnsValues;

namespace SensitiveInformationDatabase.Src.CrudManagers
{
    public class CrudManagerSensitiveInformation
    {
        private static string tableName = AnnotationsTableName<EntitySensitiveInformation>.GetTableName();

        public static void Create(EntitySensitiveInformation sensitiveInformation)
        {
            string columns = BuilderColumnsValuesSensitiveInformation
                .GetColumnsToCreate();
            string values = BuilderColumnsValuesSensitiveInformation
                .GetValuesToCreate(sensitiveInformation);
            SqlCommandInsert.Execute(tableName, columns.ToString(), values.ToString());
        }

        public static List<EntitySensitiveInformation> Read()
        {
            EntityMappingSensitiveInformation entityMappingSensitiveInformation = new EntityMappingSensitiveInformation();

            return SqlCommandSelect<EntitySensitiveInformation>.Execute(tableName, entityMappingSensitiveInformation);
        }

        public static List<EntitySensitiveInformation> Filter(Dictionary<string, string> filters)
        {
            EntityMappingSensitiveInformation entityMappingSensitiveInformation = new EntityMappingSensitiveInformation();
            Dictionary<string, string> columnValuesFilter;
            columnValuesFilter = BuilderColumnsValuesFilterSensitiveInformation
                .GetColumnsAndValuesToFilter(filters);

            return SqlCommandSelectFilter<EntitySensitiveInformation>.Execute(
                tableName, 
                entityMappingSensitiveInformation, 
                columnValuesFilter
                );
        }

        public static void Update(int id, EntitySensitiveInformation sensitiveInformation)
        {
            string columnsAndValues = BuilderColumnsValuesSensitiveInformation
                .GetValuesAndColumnsToUpdate(sensitiveInformation);
            SqlCommandUpdateById.Execute(tableName, id, columnsAndValues.ToString());
        }

        public static void Update(string uuid, EntitySensitiveInformation sensitiveInformation)
        {
            string columnsAndValues = BuilderColumnsValuesSensitiveInformation
                .GetValuesAndColumnsToUpdate(sensitiveInformation);
            SqlCommandUpdateByUuid.Execute(tableName, uuid, columnsAndValues.ToString());
        }

        public static void Delete(int id)
        {
            SqlCommandDeleteById.Execute(tableName, id);
        }

        public static void Delete(string uuid)
        {
            SqlCommandDeleteByUuid.Execute(tableName, uuid);
        }
    }
}
