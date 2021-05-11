using Newtonsoft.Json;
using System.Collections.Generic;

namespace KeyboardGameUtils.Src
{
    public class ConvertStringToDictionary<TKey, TValue>
    {
        private ConvertStringToDictionary()
        {
        }

        public static Dictionary<TKey, TValue> Convert(string JsonDictionary)
        {
            return JsonConvert.DeserializeObject<Dictionary<TKey, TValue>>(JsonDictionary);
        }
    }
}
