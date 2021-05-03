using keyboard_game_console.src.main.org.jalafoundation.devint32.optionselection;

using keyboard_game_core.src.main.org.jalafoundation.devint32.container;
using keyboard_game_core.src.main.org.jalafoundation.devint32.order;

namespace keyboard_game_console.src.main.org.jalafoundation.devint32.game
{
    internal class KeyboardGame
    {
        private static ContainerList containerList = ContainerList.GetInstance();

        private KeyboardGame()
        {
        }

        internal static void BuildKeyboard(string[] keys)
        {
            System.Console.TreatControlCAsInput = true;
            containerList.keyboardlist.AddRange(FixedArray.Fix(keys, containerList.normalKeys));
            containerList.keyboardlist.AddRange(FixedArray.Fix(keys, containerList.specialKeys));
            containerList.keyboardlist.AddRange(FixedArray.Fix(keys, containerList.functionalKeys));
            OptionSelectionMain.Select();
        }
    }
}
