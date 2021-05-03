using System.Text;
using System.Collections.Generic;

using SensitiveInformationDatabase.Src.Mappings;

namespace SensitiveInformationDatabase.Src.SqlCommands
{
    internal class SqlCommandSelectFilter<T>
    {
        private SqlCommandSelectFilter()
        {
        }

        internal static List<T> Execute(
            string tableName, 
            IEntityMapping<T> entityMapping, 
            Dictionary<string, string> columnValueFilter)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"SELECT * FROM {tableName} WHERE ");

            foreach (var columnFilter in columnValueFilter)
            {
                query.Append($"{columnFilter.Key} = {columnFilter.Value} AND ");                
            }

            query.Remove(query.Length - 4, query.Length);

            return SqlCommandExecuteQueryForSelect<T>.Execute(query.ToString(), entityMapping);
        }
    }
}
