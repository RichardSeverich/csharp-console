using System;
using System.Net.Sockets;
using System.Text;

namespace KeyboardGameClient.Src.Response
{
    public class ResponseClient
    {
        public static string responseData = string.Empty;

        public static void GetResponse(NetworkStream stream)
        {
            byte[] bytes = new Byte[1024];
            int data = stream.Read(bytes, 0, bytes.Length);
            responseData = Encoding.ASCII.GetString(bytes, 0, data);
        }
    }
}
