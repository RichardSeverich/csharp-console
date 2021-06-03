using System.Text;

namespace SensitiveInformationDatabase.Src.SqlCommands
{
    internal class SqlCommandInsert
    {
        private SqlCommandInsert()
        {
        }

        internal static void Execute(string tableName, string columns, string values)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"INSERT INTO {tableName} ({columns}) ");
            query.Append($"VALUES({values});");
            SqlCommandExecuteQuery.Execute(query.ToString());
        }
    }
}
