using System;
using System.Net.Sockets;
using System.Text;

namespace KeyboardGameServer.Src.Request
{
    internal class RequestServer
    {
        public static string GetRequest(NetworkStream stream, Byte[] bytes, int count)
        {
            string data = Encoding.ASCII.GetString(bytes, 0, count);
            Console.WriteLine($"Client Request -> {data}");
            return data;
        }
    }
}
