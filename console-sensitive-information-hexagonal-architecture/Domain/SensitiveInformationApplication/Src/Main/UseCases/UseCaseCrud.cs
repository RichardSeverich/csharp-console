using System.Collections.Generic;
using SensitiveInformationCore.Src.Main.EntityDomain;
using SensitiveInformationCore.Src.Main.Repositories;


namespace SensitiveInformationApplication.Src.Main.UseCases
{
    public class UseCaseCrud
    {
        IRepositorySensitiveInformation _repository;
        public UseCaseCrud(IRepositorySensitiveInformation repository)
        {
            _repository = repository;
        }

        public void Create(SensitiveInformation entityDomainSI)
        {
            _repository.Create(entityDomainSI);
        }

        public List<SensitiveInformation> Read()
        {
            return _repository.Read();
        }

        public void Delete(string uuid)
        {
            _repository.Delete(uuid);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Update(int id, SensitiveInformation entityDomainSI)
        {
            _repository.Update(id, entityDomainSI);
        }

        public void Update(string uuid, SensitiveInformation entityDomainSI)
        {
            _repository.Update(uuid, entityDomainSI);
        }
    }
}
