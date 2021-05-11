using System;
using System.Collections.Generic;
using KeyboardGameDataBase.Src.Repository;

namespace KeyboardGameDataBaseSqlServer.Src
{
    public class RepositoryKeyboardFunctional : IRepositoryKeyboardFunctionalKey
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
