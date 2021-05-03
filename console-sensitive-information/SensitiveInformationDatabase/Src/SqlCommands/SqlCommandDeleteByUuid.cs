using System.Text;

namespace SensitiveInformationDatabase.Src.SqlCommands
{
    internal class SqlCommandDeleteByUuid
    {
        private SqlCommandDeleteByUuid()
        {
        }

        internal static void Execute(string tableName, string uuid)
        {
            StringBuilder query = new StringBuilder();
            query.Append($"DELETE FROM {tableName} ");
            query.Append($"WHERE uuid = '{uuid}'");
            SqlCommandExecuteQuery.Execute(query.ToString());
        }
    }
}
