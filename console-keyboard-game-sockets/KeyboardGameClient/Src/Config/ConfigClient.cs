using System;

namespace KeyboardGameClient.Src.Config
{
    public class ConfigClient
    {
        public static readonly string IP_ADDRESS = Environment.GetEnvironmentVariable("TCP_IP");
        public static readonly string PORT = Environment.GetEnvironmentVariable("TCP_CLIENT_PORT");
    }
}
