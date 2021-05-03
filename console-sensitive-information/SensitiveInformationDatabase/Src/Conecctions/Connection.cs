using System;
using System.Data.SqlClient;
using SensitiveInformationDatabase.Src.Configurations;

namespace SensitiveInformationDatabase.Src.Conecctions
{
    internal class Connection
    {
        private static Connection connection;
        private SqlConnection sqlConnection;
        private string dataSource;
        private string userName;
        private string password;
        private string dataBase;

        private Connection()
        {
            ReadEnv.Load();
            dataSource = ConfigDatabase.dataSource;
            userName = ConfigDatabase.userName;
            password = ConfigDatabase.password;
            dataBase = ConfigDatabase.dataBase;
        }

        private void Build()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = dataSource;
                builder.UserID = userName;
                builder.Password = password;
                builder.InitialCatalog = dataBase;
                sqlConnection = new SqlConnection(builder.ConnectionString);
                sqlConnection.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static Connection GetInstance()
        {
            if (connection == null)
            {
                return connection = new Connection();
            }

            return connection;
        }

        internal static SqlConnection OpenConnection()
        {
            GetInstance().Build();

            return GetInstance().sqlConnection;
        }
    }
}
