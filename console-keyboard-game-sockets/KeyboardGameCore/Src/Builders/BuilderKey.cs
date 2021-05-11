using KeyboardGameCore.Src.Container;
using System.Collections.Generic;

namespace KeyboardGameCore.Src.Builders
{
    public class BuilderKey
    {
        private static ContainerList container = ContainerList.GetInstance();

        private BuilderKey()
        {
        }

        public static void Build(List<string> keysArg)
        {
            container.normalKeyboard = BuilderNormalKey.Build(keysArg, container.normalKeyboard);
            container.functionalKeyboard = BuilderFunctionalKey.Build(keysArg, container.functionalKeyboard);
            container.specialKeyboard = BuilderSpecialKey.Build(keysArg, container.specialKeyboard);
        }
    }
}
