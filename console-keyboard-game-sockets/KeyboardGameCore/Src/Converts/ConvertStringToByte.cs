using System.Text;

namespace KeyboardGameCore.Src.Converts
{
    public class ConvertStringToByte
    {
        public static byte[] Convert(string data)
        {
            return Encoding.ASCII.GetBytes(data);
        }
    }
}
