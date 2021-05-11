using System.Collections.Generic;
using System.Linq;

namespace KeyboardGameCore.Src.Order
{
    public class ToggleSort
    {
        private ToggleSort()
        {
        }

        public static Dictionary<string, int[]> Sort(Dictionary<string, int[]> dictToReverse)
        {
            return dictToReverse.Reverse().ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
        }
    }
}
