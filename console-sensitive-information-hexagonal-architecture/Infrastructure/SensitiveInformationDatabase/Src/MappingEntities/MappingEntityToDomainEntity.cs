using SensitiveInformationDatabase.Src.Entities;
using SensitiveInformationCore.Src.Main.EntityDomain;
using SensitiveInformationCore.Src.Main.Converts;

namespace SensitiveInformationDatabase.Src.MappingEntities
{
    public class MappingEntityToDomainEntity
    {
        public static SensitiveInformation GetModel(EntitySensitiveInformation entitySI)
        {
            SensitiveInformation modelSI = new SensitiveInformation();
            modelSI.id = entitySI.id;
            modelSI.uuid = entitySI.uuid.ToString();
            modelSI.type = ConvertStringToEnum<EnumSIType>.Convert(entitySI.type);
            modelSI.informationName = entitySI.informationName;
            modelSI.containerName = entitySI.containerName;
            modelSI.notes = entitySI.notes;
            modelSI.username = entitySI.username;
            modelSI.password = entitySI.password;
            modelSI.cardName = entitySI.cardName;
            modelSI.cardEntity = entitySI.cardEntity;
            modelSI.cardNumber = entitySI.cardNumber;
            modelSI.cardExpirationDate = entitySI.cardExpirationDate;
            modelSI.cardSecurityNumber = entitySI.cardSecurityNumber;
            modelSI.contactName = entitySI.contactName;
            modelSI.contactLastname = entitySI.contactLastname;
            modelSI.businessName = entitySI.businessName;
            modelSI.postalCode = entitySI.postalCode;
            modelSI.country = entitySI.country;
            modelSI.state = entitySI.state;
            modelSI.birthday = entitySI.birthday;
            modelSI.favorite = entitySI.favorite;
            modelSI.contentKey = entitySI.contentKey;
            modelSI.tagsList =  ConvertStringToList<string>.Convert(entitySI.tagsList);
            modelSI.addressesList = ConvertStringToList<string>.Convert(entitySI.addressesList);
            modelSI.phoneNumbersList = ConvertStringToList<string>.Convert(entitySI.phoneNumbersList);
            modelSI.emailsList = ConvertStringToList<string>.Convert(entitySI.emailsList);
            modelSI.urlsList = ConvertStringToList<string>.Convert(entitySI.urlsList);

            return modelSI;
        }
    }
}
