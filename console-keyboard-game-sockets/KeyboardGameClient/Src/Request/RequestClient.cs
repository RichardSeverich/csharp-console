using System;
using System.Net.Sockets;
using System.Text;

namespace KeyboardGameClient.Src.Request
{
    internal class RequestClient
    {
        internal static void SendRequest(NetworkStream stream, string req)
        {
            Byte[] data = Encoding.ASCII.GetBytes(req);
            stream.Write(data, 0, data.Length);
        }
    }
}
