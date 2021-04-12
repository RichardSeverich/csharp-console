using System.Collections.Generic;

using App.src.main.csharp.com.models;
using App.src.main.csharp.com.persistence;

namespace App.src.main.csharp.com.controllers
{
    public class HandleAdd<T> where T : AbstractModel
    {
        private HandleAdd()
        {
        }

        public static void action(List<T> list, T element)
        {
            list.Add(element);
            Persistence<T>.save(list);
        }
    }
}
