using System.Collections.Generic;
using SensitiveInformationApplication.Src.Main.UseCases;
using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationCore.Src.Main.EntityDomain;

namespace SensitiveInformationConsole.Src.Builders
{
    internal static class BuilderFilteredListSI
    {
        internal static List<SensitiveInformation> Build(
            string optionCommand, 
            string value,
            List<SensitiveInformation> listSI)
        {
            switch (optionCommand)
            {
                case CommandOptionKey.SI_UUID:
                    return UseCaseFilterList.FilterByUuid(listSI, value);

                case CommandOptionKey.SI_ID:
                    return UseCaseFilterList.FilterById(listSI, value);

                case CommandOption.SI_TYPE:
                    return UseCaseFilterList.FilterByType(listSI, value);

                case CommandOption.SI_NAME:
                    return UseCaseFilterList.FilterByName(listSI, value);

                case CommandOption.SI_CONTAINER:
                    return UseCaseFilterList.FilterByContainerName(listSI, value);

                case CommandOption.SI_NOTES:
                    return UseCaseFilterList.FilterByNotes(listSI, value);

                case CommandOption.SI_USERNAME:
                    return UseCaseFilterList.FilterByUsername(listSI, value);

                case CommandOption.SI_PASSWORD:
                    return UseCaseFilterList.FilterByPassword(listSI, value);

                case CommandOption.SI_CARD_NAME:
                    return UseCaseFilterList.FilterByCardName(listSI, value);

                case CommandOption.SI_CARD_ENTITY:
                    return UseCaseFilterList.FilterByCardEntity(listSI, value);

                case CommandOption.SI_CARD_NUMBER:
                    return UseCaseFilterList.FilterByCardNumber(listSI, value);

                case CommandOption.SI_CARD_EXP_DATE:
                    return UseCaseFilterList.FilterByCardExpirationDate(listSI, value);

                case CommandOption.SI_CARD_SECURITY_NUMBER:
                    return UseCaseFilterList.FilterByCardSecurityNumber(listSI, value);

                case CommandOption.SI_CONTACT_NAME:
                    return UseCaseFilterList.FilterByContactName(listSI, value);

                case CommandOption.SI_CONTACT_LAST_NAME:
                    return UseCaseFilterList.FilterByContactLastname(listSI, value);

                case CommandOption.SI_BUSSINES_NAME:
                    return UseCaseFilterList.FilterByBusinessName(listSI, value);

                case CommandOption.SI_POSTAL_CODE:
                    return UseCaseFilterList.FilterByPostalCode(listSI, value);

                case CommandOption.SI_COUNTRY:
                    return UseCaseFilterList.FilterByCountry(listSI, value);

                case CommandOption.SI_STATE:
                    return UseCaseFilterList.FilterByState(listSI, value);

                case CommandOption.SI_BIRTHDAY:
                    return UseCaseFilterList.FilterByBirthday(listSI, value);

                case CommandOption.SI_FAVORITE:
                    return UseCaseFilterList.FilterByFavorite(listSI);

                case CommandOption.SI_CONTENT_KEY:
                    return UseCaseFilterList.FilterByContentKey(listSI, value);

                case CommandOption.SI_URLS_LIST:
                    return UseCaseFilterList.FilterByUrlsList(listSI, value);

                case CommandOption.SI_TAGS_LIST:
                    return UseCaseFilterList.FilterByTagsList(listSI, value);

                case CommandOption.SI_EMAILS_LIST:
                    return UseCaseFilterList.FilterByEmailsList(listSI, value);

                case CommandOption.SI_PHONE_NUMBERS_LIST:
                    return UseCaseFilterList.FilterByPhoneNumbersList(listSI, value);

                case CommandOption.SI_ADDRESSES_LIST:
                    return UseCaseFilterList.FilterByAddressesList(listSI, value);
            }
            return listSI;
        }
    }
}
