using System.Linq;
using System.Collections.Generic;

using KeyboardGameCore.Src.Keys;

namespace KeyboardGameCore.Src.Builders
{
    internal class BuilderNormalKey
    {
        private BuilderNormalKey()
        {
        }

        internal static Dictionary<string, int[]> Build(List<string> keysArg, Dictionary<string, int[]> dictToBuild)
        {
            foreach (var key in keysArg)
            {
                if (NormalKey.normalKeyList.Contains(key.ToLower()))
                {
                    dictToBuild[key.ToLower()] = new int[] { 0, 0 };
                }
            }
            return dictToBuild.OrderBy(key => key.Key)
                .ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
        }
    }
}
