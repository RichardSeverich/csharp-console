using System.Text;

namespace SensitiveInformationDatabase.Src.SqlCommands
{
    internal class SqlCommandUpdateByUuid
    {
        private SqlCommandUpdateByUuid()
        {
        }

        internal static void Execute(string tableName, string uuid, string columnsAndValues)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"UPDATE {tableName} ");
            query.Append($"SET {columnsAndValues} ");
            query.Append($"WHERE uuid='{uuid}';");
            SqlCommandExecuteQuery.Execute(query.ToString());
        }
    }
}
