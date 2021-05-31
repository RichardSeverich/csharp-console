using Newtonsoft.Json;
using System.Collections.Generic;

namespace SensitiveInformationCore.Src.Main.Converts
{
    public static class ConvertListToString<T>
    {
        public static string Convert(List<T> list)
        {
            return JsonConvert.SerializeObject(list, Formatting.None);
        }
    }
}
