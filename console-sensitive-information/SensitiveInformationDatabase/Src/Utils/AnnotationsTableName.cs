using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SensitiveInformationDatabase.Src.Utils
{
    internal class AnnotationsTableName<T>
    {
        private AnnotationsTableName()
        {
        }

        internal static string GetTableName()
        {
            var dnAttribute = typeof(T).GetCustomAttributes(typeof(TableAttribute), true)
                .FirstOrDefault() as TableAttribute;

            if (dnAttribute != null)
            {
                return dnAttribute.Name;
            }

            return null;
        }
    }
}
