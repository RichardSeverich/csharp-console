using SensitiveInformationApplication.Src.Main.UseCases;
using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationConsole.Src.Validators;
using SensitiveInformationCore.Src.Main.EntityDomain;

namespace SensitiveInformationConsole.Src.Builders
{
    internal static class BuilderSensitiveInformation
    {
        internal static SensitiveInformation Build(
            string optionCommand,
            SensitiveInformation modelSI,
            string value)
        {
            switch (optionCommand)
            {
                case CommandOption.SI_TYPE:
                    ValidatorEnumSIType.Valid(value);
                    return UseCaseBuilder.AddType(modelSI, value);

                case CommandOption.SI_NAME:
                    return UseCaseBuilder.AddName(modelSI, value);

                case CommandOption.SI_CONTAINER:
                    return UseCaseBuilder.AddContainerName(modelSI, value);

                case CommandOption.SI_NOTES:
                    return UseCaseBuilder.AddNote(modelSI, value);

                case CommandOption.SI_USERNAME:
                    return UseCaseBuilder.AddUsername(modelSI, value);

                case CommandOption.SI_PASSWORD:
                    return UseCaseBuilder.AddPassword(modelSI, value);

                case CommandOption.SI_CARD_NAME:
                    return UseCaseBuilder.AddCardName(modelSI, value);

                case CommandOption.SI_CARD_ENTITY:
                    return UseCaseBuilder.AddCardEntity(modelSI, value);

                case CommandOption.SI_CARD_NUMBER:
                    return UseCaseBuilder.AddCardNumber(modelSI, value);

                case CommandOption.SI_CARD_EXP_DATE:
                    return UseCaseBuilder.AddCardExpirationDate(modelSI, value);

                case CommandOption.SI_CARD_SECURITY_NUMBER:
                    return UseCaseBuilder.AddCardSecurityNumber(modelSI, value);

                case CommandOption.SI_CONTACT_NAME:
                    return UseCaseBuilder.AddContactName(modelSI, value);

                case CommandOption.SI_CONTACT_LAST_NAME:
                    return UseCaseBuilder.AddContactLastname(modelSI, value);

                case CommandOption.SI_BUSSINES_NAME:
                    return UseCaseBuilder.AddBusinessName(modelSI, value);

                case CommandOption.SI_POSTAL_CODE:
                    return UseCaseBuilder.AddPostalCode(modelSI, value);

                case CommandOption.SI_COUNTRY:
                    return UseCaseBuilder.AddCountry(modelSI, value);

                case CommandOption.SI_STATE:
                    return UseCaseBuilder.AddState(modelSI, value);

                case CommandOption.SI_BIRTHDAY:
                    return UseCaseBuilder.AddBirthday(modelSI, value);

                case CommandOption.SI_FAVORITE:
                    return UseCaseBuilder.AddFavorite(modelSI);

                case CommandOption.SI_CONTENT_KEY:
                    return UseCaseBuilder.AddContentKey(modelSI, value);

                case CommandOption.SI_URLS_LIST:
                    return UseCaseBuilder.AddUrlsList(modelSI, value);

                case CommandOption.SI_TAGS_LIST:
                    return UseCaseBuilder.AddTagsList(modelSI, value);

                case CommandOption.SI_EMAILS_LIST:
                    return UseCaseBuilder.AddEmailsList(modelSI, value);

                case CommandOption.SI_PHONE_NUMBERS_LIST:
                    return UseCaseBuilder.AddPhoneNumbersList(modelSI, value);

                case CommandOption.SI_ADDRESSES_LIST:
                    return UseCaseBuilder.AddAddressesList(modelSI, value);
            }

            return modelSI;
        }
    }
}
