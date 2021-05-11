using Newtonsoft.Json;
using System.Collections.Generic;

namespace KeyboardGameUtils.Src
{
    public class ConvertListToString<T>
    {
        private ConvertListToString()
        {
        }

        public static string Convert(List<T> list)
        {
            return JsonConvert.SerializeObject(list, Formatting.None);
        }
    }
}
