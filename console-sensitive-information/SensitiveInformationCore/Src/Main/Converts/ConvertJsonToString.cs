using Newtonsoft.Json.Linq;

namespace SensitiveInformationCore.Src.Main.Converts
{
    internal class ConvertJsonToString
    {
        private ConvertJsonToString()
        {
        }

        internal static string Convert(JObject jObject)
        {
            return jObject.ToString();
        }
    }
}
