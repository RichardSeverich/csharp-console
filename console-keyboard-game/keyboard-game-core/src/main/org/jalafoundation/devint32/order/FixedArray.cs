using System.Collections.Generic;

namespace keyboard_game_core.src.main.org.jalafoundation.devint32.order
{
    public class FixedArray
    {
        private FixedArray()
        {
        }

        public static List<string> Fix(string[] keys, List<string> defaultList)
        {
            List<string> auxList = new List<string>();
            foreach (string key in keys)
            {
                if (defaultList.Contains(key.ToLower()))
                {
                    if (!auxList.Contains(key.ToLower()))
                    {
                        auxList.Add(key.ToLower());
                    }
                }
                if (defaultList.Contains(key.ToUpper()))
                {
                    if (!auxList.Contains(key.ToUpper()))
                    {
                        auxList.Add(key.ToUpper());
                    }
                }
            }
            auxList.Sort();
            return auxList;
        }
    }
}
