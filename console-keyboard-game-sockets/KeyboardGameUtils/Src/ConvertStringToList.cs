using Newtonsoft.Json;
using System.Collections.Generic;

namespace KeyboardGameUtils.Src
{
    public class ConvertStringToList<T>
    {
        private ConvertStringToList()
        {
        }

        public static List<T> Convert(string stringJsonList)
        {
            return JsonConvert.DeserializeObject<List<T>>(stringJsonList);
        }
    }
}
