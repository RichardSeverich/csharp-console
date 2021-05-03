using System.Collections.Generic;
using System.Linq;
using keyboard_game_core.src.main.org.jalafoundation.devint32.container;
using keyboard_game_core.src.main.org.jalafoundation.devint32.utils;

namespace keyboard_game_core.src.main.org.jalafoundation.devint32.order
{
    public class ChangeGroup
    {
        private static ContainerList container = ContainerList.GetInstance();
        private static List<string> normal = FindKeyType.GetKeyType(container.normalKeys, container.keyboardlist);
        private static List<string> special = FindKeyType.GetKeyType(container.specialKeys, container.keyboardlist);
        private static List<string> functional = FindKeyType.GetKeyType(container.functionalKeys, container.keyboardlist);
        private static List<List<string>> changeKeyboard = new List<List<string>>() { normal, special, functional };

        private ChangeGroup()
        {
        }

        public static void ChangePositionOptions(int position, List<string> options)
        {
            string aux = options[position];
            if (position == 0)
            {
                options[position] = options[position + 1];
                options[position + 1] = aux;
            }
            else
            {
                options[position] = options[position - 1];
                options[position - 1] = aux;
            }
        }

        public static void ChangePositionKeys(int position)
        {
            List<string> aux = changeKeyboard[position];
            if (position == 0)
            {
                changeKeyboard[position] = changeKeyboard[position + 1];
                changeKeyboard[position + 1] = aux;
            }
            else
            {
                changeKeyboard[position] = changeKeyboard[position - 1];
                changeKeyboard[position - 1] = aux;
            }
            container.keyboardlist.Clear();
            foreach (var key in changeKeyboard)
            {
                container.keyboardlist = container.keyboardlist.Concat(key).ToList();
            }
        }
    }
}
