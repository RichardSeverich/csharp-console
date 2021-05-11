using KeyboardGameCore.Src.Container;

namespace KeyboardGameCore.Src.PressKey
{
    public class PressKeyTest
    {
        private static ContainerList container = ContainerList.GetInstance();

        public static void Pressed(string key)
        {
            if (container.normalKeyboard.ContainsKey(key))
            {
                container.normalKeyboard[key][0] += 1;
            }
            else if (container.specialKeyboard.ContainsKey(key))
            {
                container.specialKeyboard[key][0] += 1;
            }
            else if (container.functionalKeyboard.ContainsKey(key))
            {
                container.functionalKeyboard[key][0] += 1;
            }
        }
    }
}
