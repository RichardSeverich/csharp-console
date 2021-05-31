using System.Collections.Generic;
using System.Data.SqlClient;

namespace SensitiveInformationDatabase.Src.MappingTables
{
    public interface IEntityMapping<T>
    {
        List<T> Map(SqlDataReader reader);
    }
}
