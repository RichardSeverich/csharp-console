using System.Collections.Generic;

namespace KeyboardGameDataBase.Src.Repository
{
    public interface IRepositoryKeyboard
    {
        public void Create(Dictionary<string, int[]> dict, string username);

        public Dictionary<string, int[]> Read(string username);

        public void Update(Dictionary<string, int[]> dict, string username);

        public void Delete(string username);
    }
}
