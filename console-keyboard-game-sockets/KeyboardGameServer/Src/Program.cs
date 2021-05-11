using KeyboardGameServer.Src.Server;
using KeyboardGameUtils.Src;

namespace KeyboardGameServer.Src
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadEnv.Load();
            ServerSocket.Start();
        }
    }
}
