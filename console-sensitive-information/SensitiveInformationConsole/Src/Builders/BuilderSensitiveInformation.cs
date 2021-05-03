using System;

using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationConsole.Src.Validators;
using SensitiveInformationCore.Src.Main.Converts;
using SensitiveInformationCore.Src.Main.Models;

namespace SensitiveInformationConsole.Src.Builders
{
    internal class BuilderSensitiveInformation
    {
        private const string sign = ",";

        private BuilderSensitiveInformation()
        {
        }

        internal static ModelSensitiveInformation Build(
            string optionCommand,
            ModelSensitiveInformation modelSI, 
            string value)
        {
            switch (optionCommand)
            {
                case CommandOption.SI_TYPE:
                    ValidatorEnumSIType.Valid(value);
                    modelSI.type = ConvertStringToEnum<EnumSIType>.Convert(value);
                    break;
                case CommandOption.SI_NAME:
                    modelSI.informationName = value;
                    break;
                case CommandOption.SI_CONTAINER:
                    modelSI.containerName = value;
                    break;
                case CommandOption.SI_NOTES:
                    modelSI.notes = value;
                    break;
                case CommandOption.SI_USERNAME:
                    modelSI.username = value;
                    break;
                case CommandOption.SI_PASSWORD:
                    modelSI.password = value;
                    break;
                case CommandOption.SI_CARD_NAME:
                    modelSI.cardName = value;
                    break;
                case CommandOption.SI_CARD_ENTITY:
                    modelSI.cardEntity = value;
                    break;
                case CommandOption.SI_CARD_NUMBER:
                    modelSI.cardNumber = value;
                    break;
                case CommandOption.SI_CARD_EXP_DATE:
                    modelSI.cardExpirationDate = DateTime.Parse(value);
                    break;
                case CommandOption.SI_CARD_SECURITY_NUMBER:
                    modelSI.cardSecurityNumber = Int32.Parse(value);
                    break;
                case CommandOption.SI_CONTACT_NAME:
                    modelSI.contactName = value;
                    break;
                case CommandOption.SI_CONTACT_LAST_NAME:
                    modelSI.contactLastname = value;
                    break;
                case CommandOption.SI_BUSSINES_NAME:
                    modelSI.businessName = value;
                    break;
                case CommandOption.SI_POSTAL_CODE:
                    modelSI.postalCode = Int32.Parse(value);
                    break;
                case CommandOption.SI_COUNTRY:
                    modelSI.country = value;
                    break;
                case CommandOption.SI_STATE:
                    modelSI.state = value;
                    break;
                case CommandOption.SI_BIRTHDAY:
                    modelSI.birthday = DateTime.Parse(value);
                    break;
                case CommandOption.SI_FAVORITE:
                    modelSI.favorite = true;
                    break;
                case CommandOption.SI_CONTENT_KEY:
                    modelSI.contentKey = value;
                    break;
                case CommandOption.SI_URLS_LIST:
                    modelSI.urlsList.AddRange(value.Split(sign));
                    break;
                case CommandOption.SI_TAGS_LIST:
                    modelSI.tagsList.AddRange(value.Split(sign));
                    break;
                case CommandOption.SI_EMAILS_LIST:
                    modelSI.emailsList.AddRange(value.Split(sign));
                    break;
                case CommandOption.SI_PHONE_NUMBERS_LIST:
                    modelSI.phoneNumbersList.AddRange(value.Split(sign));
                    break;
                case CommandOption.SI_ADDRESSES_LIST:
                    modelSI.addressesList.AddRange(value.Split(sign));
                    break;
            }

            return modelSI;
        }
    }
}
