using Newtonsoft.Json.Linq;

namespace SensitiveInformationCore.Src.Main.Converts
{
    public static class ConvertJsonToString
    {
        public static string Convert(JObject jObject)
        {
            return jObject.ToString();
        }
    }
}
