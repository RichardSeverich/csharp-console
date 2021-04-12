using System.Collections.Generic;

using App.src.main.csharp.com.models;
using App.src.main.csharp.com.persistence;

namespace App.src.main.csharp.com.controllers
{
    public class HandleDelete<T> where T : AbstractModel
    {
        private HandleDelete()
        {
        }

        public static void action(List<T> list, string uuid)
        {
            foreach (T element in list)
            {
                if (element.uuid == uuid)
                {
                    int index = list.IndexOf(element);
                    list.RemoveAt(index);
                    Persistence<T>.save(list);
                    break;
                }
            }
        }
    }
}
