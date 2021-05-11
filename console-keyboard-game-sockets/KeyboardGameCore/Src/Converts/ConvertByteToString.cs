using System.Text;

namespace KeyboardGameCore.Src.Converts
{
    public class ConvertByteToString
    {
        public static string Convert(byte[] b, int length)
        {
            return Encoding.ASCII.GetString(b, 0, length);
        }
    }
}
