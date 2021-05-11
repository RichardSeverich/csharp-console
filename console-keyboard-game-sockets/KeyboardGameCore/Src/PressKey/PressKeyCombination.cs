using KeyboardGameCore.Src.Container;

namespace KeyboardGameCore.Src.PressKey
{
    public class PressKeyCombination
    {
        private static ContainerList container = ContainerList.GetInstance();
        public static void Pressed(string combination)
        {
            string[] key = combination.Split("+");
            if (container.specialKeyboard.ContainsKey(key[0]))
            {
                if (!container.combinedKeys.Contains(combination))
                {
                    container.combinedKeys.Add(combination);
                    container.specialKeyboard[key[0]][1] += 1;
                    container.normalKeyboard[key[1]][1] += 1;
                }
                else
                {
                    container.combinedKeys.Remove(combination);
                    container.specialKeyboard[key[0]][1] -= 1;
                    container.normalKeyboard[key[1]][1] -= 1;
                }
            }
        }
    }
}
