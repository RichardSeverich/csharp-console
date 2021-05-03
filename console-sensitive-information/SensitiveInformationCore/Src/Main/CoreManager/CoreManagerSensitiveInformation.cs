using System.Collections.Generic;

using SensitiveInformationCore.Src.Main.Models;
using SensitiveInformationDatabase.Src.CrudManagers;
using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationCore.Src.MappingsModels.Main.SensitiveInformation;

namespace SensitiveInformationCore.Src.Main.CoreManager
{
    public class CoreManagerSensitiveInformation
    {
        public static void Create(ModelSensitiveInformation modelSI)
        {
            EntitySensitiveInformation entitySI = MappingModelToEntity.GetEntity(modelSI);
            CrudManagerSensitiveInformation.Create(entitySI);
        }

        public static List<ModelSensitiveInformation> Read()
        {
            var entitiesList = CrudManagerSensitiveInformation.Read();
            var modelsList = new List<ModelSensitiveInformation>();

            foreach (EntitySensitiveInformation entity in entitiesList)
            {
                modelsList.Add(MappingEntityToModel.GetModel(entity));
            }

            return modelsList;
        }

        public static void Delete(string uuid)
        {
            CrudManagerSensitiveInformation.Delete(uuid);
        }

        public static void Delete(int id)
        {
            CrudManagerSensitiveInformation.Delete(id);
        }

        public static void Update(int id, ModelSensitiveInformation modelSI)
        {
            EntitySensitiveInformation entitySI = MappingModelToEntity.GetEntity(modelSI);
            CrudManagerSensitiveInformation.Update(id, entitySI);
        }

        public static void Update(string uuid, ModelSensitiveInformation modelSI)
        {
            EntitySensitiveInformation entitySI = MappingModelToEntity.GetEntity(modelSI);
            CrudManagerSensitiveInformation.Update(uuid, entitySI);
        }
    }
}
