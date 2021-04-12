using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using App.src.main.csharp.com.models;

namespace App.src.main.csharp.com.persistence
{
    public class Persistence<T> where T : AbstractModel
    {
        private static FileStream fileStream;
        private static BinaryFormatter binaryFormatter;

        private Persistence()
        {
        }

        public static void save(List<T> list) 
        {
            try
            {
                string pathFileName = PathFileName.getPathFileName<T>();
                fileStream = new FileStream(pathFileName, FileMode.OpenOrCreate, FileAccess.Write);
                binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                fileStream.Close();
            }
        }

        public static List<T> read()
        {
            List<T> list = new List<T>();
            try
            {
                string pathFileName = PathFileName.getPathFileName<T>();
                fileStream = new FileStream(pathFileName, FileMode.OpenOrCreate, FileAccess.Read);
                binaryFormatter = new BinaryFormatter();
                list = (List<T>)binaryFormatter.Deserialize(fileStream);
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return list;
            }
            finally
            {
                fileStream.Close();
            }
        }
    }
}
