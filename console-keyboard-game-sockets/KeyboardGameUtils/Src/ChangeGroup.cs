using System.Collections.Generic;

namespace KeyboardGameUtils.Src
{
    public class ChangeGroup
    {
        private ChangeGroup()
        {
        }

        public static void ChangePosition<T>(int position, List<T> list)
        {
            var aux = list[position];
            if (position == 0)
            {
                list[position] = list[position + 1];
                list[position + 1] = aux;
            }
            else
            {
                list[position] = list[position - 1];
                list[position - 1] = aux;
            }
        }
    }
}
