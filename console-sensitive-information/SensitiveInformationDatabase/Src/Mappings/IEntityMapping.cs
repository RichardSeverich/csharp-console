using System.Collections.Generic;
using System.Data.SqlClient;

namespace SensitiveInformationDatabase.Src.Mappings
{
    public interface IEntityMapping<T>
    {
        List<T> Map(SqlDataReader reader);
    }
}
