using Newtonsoft.Json.Linq;
using System;

namespace SensitiveInformationCore.Src.Main.Converts
{
    internal class ConvertStringToJson
    {
        private ConvertStringToJson()
        {
        }

        internal static JObject Convert(string str)
        {
            try
            {
                JObject jObject = JObject.Parse(str);

                return jObject;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ": " + ex.Message);

                return null;
            }
        }
    }
}
