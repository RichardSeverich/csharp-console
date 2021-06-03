using System;

namespace SensitiveInformationCore.Src.Main.Converts
{
    public static class ConvertStringToEnum<T>
    {
        public static T Convert(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
