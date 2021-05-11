using KeyboardGameConsole.Src.Game;
using KeyboardGameUtils.Src;

namespace KeyboardGameConsole.Src
{
    class App
    {
        static void Main(string[] args)
        {
            ReadEnv.Load();
            KeyboardGame.Run(args);
        }
    }
}
