using System.Collections.Generic;
using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationDatabase.Src.Utils;

namespace SensitiveInformationDatabase.Src.BuildersColumnsValues
{
    internal class BuilderColumnsValuesFilterSensitiveInformation
    {
        private static Dictionary<string, string> columnsNames = AnnotationsColumnName<EntitySensitiveInformation>.GetColumnsNames();
        
        internal static Dictionary<string, string> GetColumnsAndValuesToFilter(Dictionary<string, string> attributeValue)
        {
            Dictionary<string, string> columnsAndValues = new Dictionary<string, string>();
           
            foreach (var item in attributeValue)
            {
                columnsAndValues.Add(columnsNames[item.Key], item.Value);
            }

            return columnsAndValues;
        }
    }
}
