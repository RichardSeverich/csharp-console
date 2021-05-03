using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SensitiveInformationDatabase.Src.Utils
{
    internal class AnnotationsColumnName<T>
    {
        private AnnotationsColumnName()
        {
        }

        internal static Dictionary<string, string> GetColumnsNames()
        {
            Dictionary<string, string> fieldColumn = new Dictionary<string, string>();

            foreach (var field in typeof(T).GetFields())
            {
                fieldColumn.Add(field.Name, field.GetCustomAttribute<ColumnAttribute>().Name);
            }

            return fieldColumn;
        }
    }
}
