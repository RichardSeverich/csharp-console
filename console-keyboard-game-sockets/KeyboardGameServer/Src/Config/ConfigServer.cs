using System;

namespace KeyboardGameServer.Src.Config
{
    internal class ConfigServer
    {
        internal static readonly string IP_ADDRESS = Environment.GetEnvironmentVariable("TCP_IP");
        internal static readonly string PORT = Environment.GetEnvironmentVariable("TCP_SERVER_PORT");
        internal static readonly string LISTENERS = Environment.GetEnvironmentVariable("TCP_NUM_LISTENERS");
    }
}
