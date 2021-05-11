using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace KeyboardGameUtils.Src
{
    public class ConvertDictionaryToString<TKey, TValue>
    {
        private ConvertDictionaryToString()
        {
        }

        public static string Convert(Dictionary<TKey, TValue> dictionary)
        {
            return JsonConvert.SerializeObject(dictionary, Formatting.None);
        }
    }
}
