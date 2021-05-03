using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace SensitiveInformationDatabase.Src.Utils
{
    internal class AnnotationsColumnNameWithGetSet<T>
    {
        private AnnotationsColumnNameWithGetSet()
        {
        }

        internal static Dictionary<string, string> GetColumnsNames()
        {
            Dictionary<string, string> fieldColumn = new Dictionary<string, string>();

            foreach (var field in typeof(T).GetProperties())
            {
                fieldColumn.Add(field.Name, field.GetCustomAttribute<ColumnAttribute>().Name);
            }

            return fieldColumn;
        }
    }
}
