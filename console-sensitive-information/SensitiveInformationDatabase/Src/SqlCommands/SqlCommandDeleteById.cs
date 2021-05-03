using System.Text;

namespace SensitiveInformationDatabase.Src.SqlCommands
{
    internal class SqlCommandDeleteById
    {
        private SqlCommandDeleteById()
        {
        }

        internal static void Execute(string tableName, int id)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"DELETE FROM {tableName} ");
            query.Append($"WHERE id = {id}");
            SqlCommandExecuteQuery.Execute(query.ToString());
        }
    }
}
