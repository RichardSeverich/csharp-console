using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationCore.Src.Main.Models;
using SensitiveInformationCore.Src.Main.Converts;

namespace SensitiveInformationCore.Src.MappingsModels.Main.SensitiveInformation
{
    public class MappingModelToEntity
    {
        public static EntitySensitiveInformation GetEntity(ModelSensitiveInformation modelSI)
        {
            EntitySensitiveInformation entitySI = new EntitySensitiveInformation();
            entitySI.type = modelSI.type.ToString();
            entitySI.informationName = modelSI.informationName;
            entitySI.containerName = modelSI.containerName;
            entitySI.notes = modelSI.notes;
            entitySI.username = modelSI.username;
            entitySI.password = modelSI.password;
            entitySI.cardName = modelSI.cardName;
            entitySI.cardEntity = modelSI.cardEntity;
            entitySI.cardNumber = modelSI.cardNumber;
            entitySI.cardExpirationDate = modelSI.cardExpirationDate;
            entitySI.cardSecurityNumber = modelSI.cardSecurityNumber;
            entitySI.contactName = modelSI.contactName;
            entitySI.contactLastname = modelSI.contactLastname;
            entitySI.businessName = modelSI.businessName;
            entitySI.postalCode = modelSI.postalCode;
            entitySI.country = modelSI.country;
            entitySI.state = modelSI.state;
            entitySI.birthday = modelSI.birthday;
            entitySI.favorite = modelSI.favorite;
            entitySI.contentKey = modelSI.contentKey;
            entitySI.tagsList = ConvertListToString<string>.Convert(modelSI.tagsList);
            entitySI.addressesList = ConvertListToString<string>.Convert(modelSI.addressesList);
            entitySI.phoneNumbersList = ConvertListToString<string>.Convert(modelSI.phoneNumbersList);
            entitySI.emailsList = ConvertListToString<string>.Convert(modelSI.emailsList);
            entitySI.urlsList = ConvertListToString<string>.Convert(modelSI.urlsList);

            return entitySI;
        }
    }
}
