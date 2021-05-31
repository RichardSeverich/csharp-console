using System.Data.SqlClient;

using SensitiveInformationDatabase.Src.Conecctions;

namespace SensitiveInformationDatabase.Src.SqlCommands
{
    internal class SqlCommandExecuteQuery
    {
        private SqlCommandExecuteQuery()
        {
        }

        internal static void Execute(string query)
        {
            using (SqlConnection connection = Connection.OpenConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
