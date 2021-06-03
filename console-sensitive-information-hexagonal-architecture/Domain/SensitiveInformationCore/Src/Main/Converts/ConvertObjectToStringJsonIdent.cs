using Newtonsoft.Json;

namespace SensitiveInformationCore.Src.Main.Converts
{
    public static class ConvertObjectToStringJsonIdent<T>
    {
        public static string Convert(T genericObject)
        {
            return JsonConvert.SerializeObject(genericObject, Formatting.Indented);
        }
    }
}
