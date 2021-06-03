using System;

namespace SensitiveInformationDatabase.Src.Configurations
{
    internal class ConfigDatabase
    {
        internal static readonly string dataSource = Environment.GetEnvironmentVariable("HOST")
            + "," + Environment.GetEnvironmentVariable("PORT");
        internal static readonly string userName = Environment.GetEnvironmentVariable("USER");
        internal static readonly string password = Environment.GetEnvironmentVariable("PASSWORD");
        internal static readonly string dataBase = Environment.GetEnvironmentVariable("DATABASE");
    }
}
