using KeyboardGameConsole.Src.OptionSelection;

using KeyboardGameClient.Src.Client;
using KeyboardGameUtils.Src;
using System.Collections.Generic;

namespace KeyboardGameConsole.Src.Game
{
    public class KeyboardGame
    {
        public static void Run(string[] keys)
        {
            System.Console.TreatControlCAsInput = true;
            string stringkeys = ConvertListToString<string>.Convert(new List<string>(keys));
            ClientSocket.SendRequest($"Build {stringkeys}");
            OptionSelectionMain.Select();
        }
    }
}
