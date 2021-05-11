using System.Text;

namespace KeyboardGameUtils.Src
{
    public class ConvertStringToByte
    {
        public static byte[] Convert(string data)
        {
            return Encoding.ASCII.GetBytes(data);
        }
    }
}
