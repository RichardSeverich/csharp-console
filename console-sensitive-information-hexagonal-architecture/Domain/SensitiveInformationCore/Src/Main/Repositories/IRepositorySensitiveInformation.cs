using SensitiveInformationCore.Src.Main.EntityDomain;
using System.Collections.Generic;

namespace SensitiveInformationCore.Src.Main.Repositories
{
    public interface IRepositorySensitiveInformation
    {
        public void Create(SensitiveInformation sensitiveInformation);

        public List<SensitiveInformation> Read();

        public void Update(int id, SensitiveInformation sensitiveInformation);

        public void Update(string uuid, SensitiveInformation sensitiveInformation);

        public void Delete(int id);

        public void Delete(string uuid);
    }
}
