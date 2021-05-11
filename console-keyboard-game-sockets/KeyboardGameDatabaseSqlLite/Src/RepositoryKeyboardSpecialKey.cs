using KeyboardGameDataBase.Src.Repository;
using System;
using System.Collections.Generic;

namespace KeyboardGameDatabaseSqlLite.Src
{
    public class RepositoryKeyboardSpecialKey : IRepositoryKeyboardSpecialKey
    {
        public void Create(Dictionary<string, int[]> dict, string username)
        {
            throw new NotImplementedException();
        }

        public void Delete(string username)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, int[]> Read(string username)
        {
            throw new NotImplementedException();
        }

        public void Update(Dictionary<string, int[]> dict, string username)
        {
            throw new NotImplementedException();
        }
    }
}
