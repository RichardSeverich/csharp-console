using KeyboardGameDataBase.Src.Repository;

namespace KeyboardGameCore.Src.Repository
{
    class RepositoryFactory
    {
        public static IRepositoryKeyboardFunctionalKey GetFunctionalRepository(string db)
        {
            switch (db)
            {
                case "SQL_SERVER":
                    return new KeyboardGameDatabaseSqlLite.Src.RepositoryKeyboardFunctional();

                case "SQL_LITE":
                    return new KeyboardGameDataBaseSqlServer.Src.RepositoryKeyboardFunctional();

                default:
                    return new KeyboardGameDataBaseSqlServer.Src.RepositoryKeyboardFunctional();
            }
        }

        public static IRepositoryKeyboardNormalKey GetNormalRepository(string db)
        {
            switch (db)
            {
                case "SQL_SERVER":
                    return new KeyboardGameDatabaseSqlLite.Src.RepositoryKeyboardNormalKey();

                case "SQL_LITE":
                    return new KeyboardGameDataBaseSqlServer.Src.RepositoryKeyboardNormalKey();

                default:
                    return new KeyboardGameDataBaseSqlServer.Src.RepositoryKeyboardNormalKey();
            }
        }

        public static IRepositoryKeyboardSpecialKey GetSpecialRepository(string db)
        {
            switch (db)
            {
                case "SQL_SERVER":
                    return new KeyboardGameDatabaseSqlLite.Src.RepositoryKeyboardSpecialKey();

                case "SQL_LITE":
                    return new KeyboardGameDataBaseSqlServer.Src.RepositoryKeyboardSpecialKey();

                default:
                    return new KeyboardGameDataBaseSqlServer.Src.RepositoryKeyboardSpecialKey();
            }
        }
    }
}
