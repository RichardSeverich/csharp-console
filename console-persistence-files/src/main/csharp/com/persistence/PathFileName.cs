using System;

using App.src.main.csharp.com.models;

namespace App.src.main.csharp.com.persistence
{
    public class PathFileName
    {
        private PathFileName()
        {
        }

        public static string getPathFileName<T>() where T : AbstractModel
        {
            string typeName = typeof(T).Name;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path = path.Substring(0, path.Length - 17);
            string fullPath = path + @"savedata\";
            switch (typeName)
            {
                case "User":
                    return fullPath + "users.dat";
                default:
                    return fullPath + "empty.dat";
            }
        }
    }
}
