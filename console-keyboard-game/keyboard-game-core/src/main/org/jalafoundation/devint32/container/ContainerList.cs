using System.Collections.Generic;

namespace keyboard_game_core.src.main.org.jalafoundation.devint32.container
{
    public class ContainerList
    {
        private static ContainerList instance;
        public List<string> normalKeys;
        public List<string> functionalKeys;
        public List<string> specialKeys;
        public List<string> combinedKeys;
        public List<string> keyboardlist;
        public Dictionary<string, int[]> keyedCombined;

        private ContainerList()
        {
            combinedKeys = new List<string>();
            normalKeys = new List<string>();
            normalKeys.Add("a");
            normalKeys.Add("b");
            normalKeys.Add("c");
            normalKeys.Add("d");
            normalKeys.Add("e");
            functionalKeys = new List<string>();
            functionalKeys.Add("F1");
            functionalKeys.Add("F2");
            functionalKeys.Add("F3");
            functionalKeys.Add("F4");
            functionalKeys.Add("F5");
            specialKeys = new List<string>();
            specialKeys.Add("alt");
            specialKeys.Add("ctrl");
            specialKeys.Add("shift");
            keyboardlist = new List<string>();
            keyedCombined = new Dictionary<string, int[]>();
            keyedCombined.Add("a", new int[]{ 0, 0 });
            keyedCombined.Add("b", new int[] { 0, 0 });
            keyedCombined.Add("c", new int[] { 0, 0 });
            keyedCombined.Add("d", new int[] { 0, 0 });
            keyedCombined.Add("e", new int[] { 0, 0 });
            keyedCombined.Add("alt", new int[] { 0, 0 });
            keyedCombined.Add("ctrl", new int[] { 0, 0 });
            keyedCombined.Add("shift", new int[] { 0, 0 });
            keyedCombined.Add("F1", new int[] { 0, 0 });
            keyedCombined.Add("F2", new int[] { 0, 0 });
            keyedCombined.Add("F3", new int[] { 0, 0 });
            keyedCombined.Add("F4", new int[] { 0, 0 });
            keyedCombined.Add("F5", new int[] { 0, 0 });
        }

        public static ContainerList GetInstance()
        {
            if (instance == null)
            {
                return instance = new ContainerList();
            }
            return instance;
        }
    }
}
