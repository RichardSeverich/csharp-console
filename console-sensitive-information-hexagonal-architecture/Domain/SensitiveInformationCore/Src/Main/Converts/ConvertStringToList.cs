using Newtonsoft.Json;
using System.Collections.Generic;

namespace SensitiveInformationCore.Src.Main.Converts
{
    public static class ConvertStringToList<T>
    {
        public static List<T> Convert(string stringJsonList)
        {
            return JsonConvert.DeserializeObject<List<T>>(stringJsonList);
        }
    }
}
