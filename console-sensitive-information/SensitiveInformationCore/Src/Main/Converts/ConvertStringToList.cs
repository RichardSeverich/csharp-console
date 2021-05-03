using Newtonsoft.Json;
using System.Collections.Generic;

namespace SensitiveInformationCore.Src.Main.Converts
{
    internal class ConvertStringToList<T>
    {
        private ConvertStringToList()
        {
        }

        internal static List<T> Convert(string stringJsonList)
        {
            return JsonConvert.DeserializeObject<List<T>>(stringJsonList);
        }
    }
}
