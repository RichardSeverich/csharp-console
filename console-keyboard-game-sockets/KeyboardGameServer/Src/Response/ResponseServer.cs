using System;
using System.Net.Sockets;
using System.Text;

namespace KeyboardGameServer.Src.Response
{
    internal class ResponseServer
    {
        internal static void SendResponse(NetworkStream stream, string response)
        {
            byte[] msg = Encoding.ASCII.GetBytes(response);
            stream.Write(msg, 0, msg.Length);
            Console.WriteLine($"Server Response -> {response}");
        }
    }
}
