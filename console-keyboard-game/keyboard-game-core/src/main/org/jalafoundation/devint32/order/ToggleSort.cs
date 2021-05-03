using System.Collections.Generic;

namespace keyboard_game_core.src.main.org.jalafoundation.devint32.order
{
    public class ToggleSort
    {
        private ToggleSort()
        {
        }

        public static void Sort(List<string> listDefault, List<string> listToReverse)
        {
            List<string> auxList = new List<string>();
            List<int> indexAuxlist = new List<int>();
            foreach (string keyDefault in listDefault)
            {
                if (listToReverse.Contains(keyDefault))
                {
                    auxList.Add(keyDefault);
                    indexAuxlist.Add(listToReverse.IndexOf(keyDefault));
                }
            }
            auxList.Reverse();
            for (int i = 0; i < indexAuxlist.Count; i++)
            {
                listToReverse.RemoveAt(indexAuxlist[i]);
                listToReverse.Insert(indexAuxlist[i], auxList[i]);
            }
        }
    }
}
