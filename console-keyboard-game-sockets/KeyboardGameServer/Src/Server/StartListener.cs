using System.Net;
using System.Net.Sockets;

namespace KeyboardGameServer.Src.Server
{
    internal class StartListener
    {
        internal static TcpListener Start(string ipAddress, int port, int listeners)
        {
            IPAddress localAddr = IPAddress.Parse(ipAddress);
            TcpListener listener = new TcpListener(localAddr, port);
            listener.Start(listeners);
            return listener;
        }
    }
}
