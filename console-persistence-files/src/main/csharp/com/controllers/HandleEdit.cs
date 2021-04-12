using System.Collections.Generic;

using App.src.main.csharp.com.models;
using App.src.main.csharp.com.persistence;

namespace App.src.main.csharp.com.controllers
{
    public class HandleEdit<T> where T : AbstractModel
    {
        public static void action(List<T> list, string uuid, T item)
        {
            foreach (T element in list)
            {
                if (element.uuid == uuid)
                {
                    int index = list.IndexOf(element);
                    list.RemoveAt(index);
                    list.Insert(index, item);
                    Persistence<T>.save(list);
                    break;
                }
            }
        }
    }
}
