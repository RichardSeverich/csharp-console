using System.Text;
using System.Collections.Generic;

using SensitiveInformationDatabase.Src.MappingTables;

namespace SensitiveInformationDatabase.Src.SqlCommands
{
    internal class SqlCommandSelect<T>
    {
        private SqlCommandSelect()
        {
        }

        internal static List<T> Execute(string tableName, IEntityMapping<T> entityMapping)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"SELECT * FROM {tableName}");

            return SqlCommandExecuteQueryForSelect<T>.Execute(query.ToString(), entityMapping);
        }
    }
}
