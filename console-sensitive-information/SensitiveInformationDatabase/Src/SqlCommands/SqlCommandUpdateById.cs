using System.Text;

namespace SensitiveInformationDatabase.Src.SqlCommands
{
    internal class SqlCommandUpdateById
    {
        private SqlCommandUpdateById()
        {
        }

        internal static void Execute(string tableName, int id, string columnsAndValues)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"UPDATE {tableName} ");
            query.Append($"SET {columnsAndValues} ");
            query.Append($"WHERE id={id};");
            SqlCommandExecuteQuery.Execute(query.ToString());
        }
    }
}
