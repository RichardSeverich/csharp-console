using Newtonsoft.Json;
using System.Collections.Generic;

namespace SensitiveInformationCore.Src.Main.Converts
{
    internal class ConvertListToString<T>
    {
        private ConvertListToString()
        {
        }

        internal static string Convert(List<T> list)
        {
            return JsonConvert.SerializeObject(list, Formatting.None);
        }
    }
}
