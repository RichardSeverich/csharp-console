using System.Collections.Generic;

namespace KeyboardGameCore.Src.Container
{
    public class ContainerList
    {
        private static ContainerList instance;
        public Dictionary<string, int[]> normalKeyboard;
        public Dictionary<string, int[]> functionalKeyboard;
        public Dictionary<string, int[]> specialKeyboard;
        public List<string> combinedKeys;

        private ContainerList()
        {
            combinedKeys = new List<string>();
            normalKeyboard = new Dictionary<string, int[]>();
            functionalKeyboard = new Dictionary<string, int[]>();
            specialKeyboard = new Dictionary<string, int[]>();
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
