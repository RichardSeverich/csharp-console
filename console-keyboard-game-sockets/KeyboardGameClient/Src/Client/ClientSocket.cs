using System;
using System.Net.Sockets;
using KeyboardGameClient.Src.Config;
using KeyboardGameClient.Src.Request;
using KeyboardGameClient.Src.Response;

namespace KeyboardGameClient.Src.Client
{
    public class ClientSocket
    {
        public static void SendRequest(string message)
        {
            string ipAddress = ConfigClient.IP_ADDRESS;
            int port = Int32.Parse(ConfigClient.PORT);
            TcpClient client = null;
            NetworkStream stream = null;
            try
            {
                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();
                RequestClient.SendRequest(stream, message);
                ResponseClient.GetResponse(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            client.Close();
            stream.Close();
        }
    }
}
