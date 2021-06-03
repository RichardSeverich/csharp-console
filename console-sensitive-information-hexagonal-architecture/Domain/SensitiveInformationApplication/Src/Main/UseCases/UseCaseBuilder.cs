using SensitiveInformationCore.Src.Main.Converts;
using SensitiveInformationCore.Src.Main.EntityDomain;
using System;

namespace SensitiveInformationApplication.Src.Main.UseCases
{
    public static class UseCaseBuilder
    {
        private const string sign = ",";

        public static SensitiveInformation AddType(SensitiveInformation modelSI, string value)
        {
            modelSI.type = ConvertStringToEnum<EnumSIType>.Convert(value);
            return modelSI;
        }

        public static SensitiveInformation AddName(SensitiveInformation modelSI, string value)
        {
            modelSI.informationName = value;
            return modelSI;
        }

        public static SensitiveInformation AddContainerName(SensitiveInformation modelSI, string value)
        {
            modelSI.containerName = value;
            return modelSI;
        }

        public static SensitiveInformation AddNote(SensitiveInformation modelSI, string value)
        {
            modelSI.notes = value;
            return modelSI;
        }

        public static SensitiveInformation AddUsername(SensitiveInformation modelSI, string value)
        {
            modelSI.username = value;
            return modelSI;
        }

        public static SensitiveInformation AddPassword(SensitiveInformation modelSI, string value)
        {
            modelSI.password = value;
            return modelSI;
        }

        public static SensitiveInformation AddCardName(SensitiveInformation modelSI, string value)
        {
            modelSI.cardName = value;
            return modelSI;
        }

        public static SensitiveInformation AddCardEntity(SensitiveInformation modelSI, string value)
        {
            modelSI.cardEntity = value;
            return modelSI;
        }

        public static SensitiveInformation AddCardNumber(SensitiveInformation modelSI, string value)
        {
            modelSI.cardNumber = value;
            return modelSI;
        }

        public static SensitiveInformation AddCardExpirationDate(SensitiveInformation modelSI, string value)
        {
            modelSI.cardExpirationDate = DateTime.Parse(value);
            return modelSI;
        }

        public static SensitiveInformation AddCardSecurityNumber(SensitiveInformation modelSI, string value)
        {
            modelSI.cardSecurityNumber = Int32.Parse(value);
            return modelSI;
        }

        public static SensitiveInformation AddContactName(SensitiveInformation modelSI, string value)
        {
            modelSI.contactName = value;
            return modelSI;
        }

        public static SensitiveInformation AddContactLastname(SensitiveInformation modelSI, string value)
        {
            modelSI.contactLastname = value;
            return modelSI;
        }

        public static SensitiveInformation AddBusinessName(SensitiveInformation modelSI, string value)
        {
            modelSI.businessName = value;
            return modelSI;
        }

        public static SensitiveInformation AddPostalCode(SensitiveInformation modelSI, string value)
        {
            modelSI.postalCode = Int32.Parse(value);
            return modelSI;
        }

        public static SensitiveInformation AddCountry(SensitiveInformation modelSI, string value)
        {
            modelSI.country = value;
            return modelSI;
        }

        public static SensitiveInformation AddState(SensitiveInformation modelSI, string value)
        {
            modelSI.state = value;
            return modelSI;
        }

        public static SensitiveInformation AddBirthday(SensitiveInformation modelSI, string value)
        {
            modelSI.birthday = DateTime.Parse(value);
            return modelSI;
        }

        public static SensitiveInformation AddFavorite(SensitiveInformation modelSI)
        {
            modelSI.favorite = true;
            return modelSI;
        }

        public static SensitiveInformation AddContentKey(SensitiveInformation modelSI, string value)
        {
            modelSI.contentKey = value;
            return modelSI;
        }

        public static SensitiveInformation AddUrlsList(SensitiveInformation modelSI, string value)
        {
            modelSI.urlsList.AddRange(value.Split(sign));
            return modelSI;
        }

        public static SensitiveInformation AddTagsList(SensitiveInformation modelSI, string value)
        {
            modelSI.tagsList.AddRange(value.Split(sign));
            return modelSI;
        }

        public static SensitiveInformation AddEmailsList(SensitiveInformation modelSI, string value)
        {
            modelSI.emailsList.AddRange(value.Split(sign));
            return modelSI;
        }

        public static SensitiveInformation AddPhoneNumbersList(SensitiveInformation modelSI, string value)
        {
            modelSI.phoneNumbersList.AddRange(value.Split(sign));
            return modelSI;
        }

        public static SensitiveInformation AddAddressesList(SensitiveInformation modelSI, string value)
        {
            modelSI.addressesList.AddRange(value.Split(sign));
            return modelSI;
        }
    }
}
