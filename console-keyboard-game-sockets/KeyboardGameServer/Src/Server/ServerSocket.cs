using System;
using System.Net.Sockets;

using KeyboardGameServer.Src.Config;
using KeyboardGameServer.Src.Request;
using KeyboardGameServer.Src.Response;

namespace KeyboardGameServer.Src.Server
{
    internal class ServerSocket
    {
        public static void Start()
        {
            TcpListener server = null;
            TcpClient client = null;
            string ipAddress = ConfigServer.IP_ADDRESS;
            int port = Int32.Parse(ConfigServer.PORT);
            int limitClients = Int32.Parse(ConfigServer.LISTENERS);
            Byte[] bytes = new Byte[1024];
            try
            {
                server = StartListener.Start(ipAddress, port, limitClients);
                Console.Clear();
                Console.WriteLine($"Server start in:\nIP: {ipAddress}\nPORT: {port}\nCLIENTS LIMIT: {limitClients}");
                while (true)
                {
                    Console.WriteLine("\nWaiting for Client Request...");
                    client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    int i;
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        string req = RequestServer.GetRequest(stream, bytes, i);
                        ResponseManager.GetResponse(stream, req);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            client.Close();
            server.Stop();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }
    }
}
