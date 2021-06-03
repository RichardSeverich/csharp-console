using SensitiveInformationCore.Src.Main.EntityDomain;
using SensitiveInformationCore.Src.Main.Repositories;
using SensitiveInformationDatabase.Src.CrudManagers;
using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationDatabase.Src.MappingEntities;
using System.Collections.Generic;

namespace SensitiveInformationDatabase.Src.Repository
{
    public class RepositorySensitiveInformation : IRepositorySensitiveInformation
    {
        public void Create(SensitiveInformation modelSI)
        {
            EntitySensitiveInformation entitySI = MappingDomainEntityToEntity.GetEntity(modelSI);
            CrudManagerSensitiveInformation.Create(entitySI);
        }

        public List<SensitiveInformation> Read()
        {
            var entitiesList = CrudManagerSensitiveInformation.Read();
            var modelsList = new List<SensitiveInformation>();

            foreach (EntitySensitiveInformation entity in entitiesList)
            {
                modelsList.Add(MappingEntityToDomainEntity.GetModel(entity));
            }

            return modelsList;
        }

        public void Delete(string uuid)
        {
            CrudManagerSensitiveInformation.Delete(uuid);
        }

        public void Delete(int id)
        {
            CrudManagerSensitiveInformation.Delete(id);
        }

        public void Update(int id, SensitiveInformation modelSI)
        {
            EntitySensitiveInformation entitySI = MappingDomainEntityToEntity.GetEntity(modelSI);
            CrudManagerSensitiveInformation.Update(id, entitySI);
        }

        public void Update(string uuid, SensitiveInformation modelSI)
        {
            EntitySensitiveInformation entitySI = MappingDomainEntityToEntity.GetEntity(modelSI);
            CrudManagerSensitiveInformation.Update(uuid, entitySI);
        }
    }
}
