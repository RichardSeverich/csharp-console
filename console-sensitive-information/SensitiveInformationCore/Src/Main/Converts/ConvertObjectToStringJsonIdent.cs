using Newtonsoft.Json;

namespace SensitiveInformationCore.Src.Main.Converts
{
    internal class ConvertObjectToStringJsonIdent<T>
    {
        private ConvertObjectToStringJsonIdent()
        {
        }

        internal static string Convert(T genericObject)
        {
            return JsonConvert.SerializeObject(genericObject, Formatting.Indented);
        }
    }
}
