using System.Collections.Generic;
using System.Text;

using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationDatabase.Src.Utils;

namespace SensitiveInformationDatabase.Src.BuildersColumnsValues
{
    internal class BuilderColumnsAndValuesUser
    {
        private static Dictionary<string, string> columnsNames = AnnotationsColumnName<EntityUser>.GetColumnsNames();

        internal static string GetColumnsToCreate()
        {
            StringBuilder columns = new StringBuilder();
            columns.Append($"{columnsNames["username"]},");
            columns.Append($"{columnsNames["password"]}");

            return columns.ToString();
            
        }

        internal static string GetValuesToCreate(EntityUser user)
        {
            StringBuilder values = new StringBuilder();
            values.Append($"'{ user.username }',");
            values.Append($"'{ user.password }'");

            return values.ToString();
        }

        internal static string GetValuesAndColumnsToUpdate(EntityUser user)
        {
            StringBuilder columnsAndValues = new StringBuilder();
            columnsAndValues.Append($"{columnsNames["username"]}='{user.username}',");
            columnsAndValues.Append($"{columnsNames["password"]}='{user.password}'");

            return columnsAndValues.ToString();
        }
    }
}
