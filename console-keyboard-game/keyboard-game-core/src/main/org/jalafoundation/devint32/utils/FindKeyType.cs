using System.Collections.Generic;

using keyboard_game_core.src.main.org.jalafoundation.devint32.container;

namespace keyboard_game_core.src.main.org.jalafoundation.devint32.utils
{
    public class FindKeyType
    {
        private static ContainerList container = ContainerList.GetInstance();

        private FindKeyType()
        {
        }

        public static List<string> GetKeyType(List<string> typeKeyList, List<string> keysList)
        {
            List<string> listAux = new List<string>();
            foreach (var key in keysList)
            {
                if (typeKeyList.Contains(key))
                {
                    listAux.Add(key);
                }
            }
            return listAux;
        }

        public static bool isNormal(string data)
        {
            return container.normalKeys.Contains(data.ToLower()) && container.keyboardlist.Contains(data.ToLower());
        }

        public static bool isSpecial(string data)
        {
            return container.specialKeys.Contains(data.ToLower()) && container.keyboardlist.Contains(data.ToLower());
        }

        public static bool isFunctional(string data)
        {
            return container.functionalKeys.Contains(data.ToUpper()) && container.keyboardlist.Contains(data.ToUpper());
        }
    }
}
