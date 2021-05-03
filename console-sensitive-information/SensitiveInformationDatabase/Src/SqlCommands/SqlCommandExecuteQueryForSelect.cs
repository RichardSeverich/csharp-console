using System.Collections.Generic;
using System.Data.SqlClient;

using SensitiveInformationDatabase.Src.Conecctions;
using SensitiveInformationDatabase.Src.Mappings;

namespace SensitiveInformationDatabase.Src.SqlCommands
{
    internal class SqlCommandExecuteQueryForSelect<T>
    {
        private SqlCommandExecuteQueryForSelect()
        {
        }

        internal static List<T> Execute(string query, IEntityMapping<T> entityMapping)
        {
            List<T> list = new List<T>();
            using (SqlConnection connection = Connection.OpenConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                list = entityMapping.Map(reader);
                connection.Close();
            }

            return list;
        }
    }
}
