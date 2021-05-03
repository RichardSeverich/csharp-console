using System.Collections.Generic;
using System.Linq;

using SensitiveInformationConsole.Src.Commands;
using SensitiveInformationCore.Src.Main.Models;

namespace SensitiveInformationConsole.Src.Builders
{
    internal class BuilderFilteredListSI
    {
        private const string sign = ",";

        private BuilderFilteredListSI()
        {
        }

        internal static List<ModelSensitiveInformation> Build(
            string optionCommand, 
            string value,
            List<ModelSensitiveInformation> listSI)
        {
            switch (optionCommand)
            {
                case CommandOptionKey.SI_UUID:
                    return listSI.Where(si => si.uuid.Equals(value)).ToList();

                case CommandOptionKey.SI_ID:
                    return listSI.Where(si => si.id.ToString().Equals(value)).ToList();

                case CommandOption.SI_TYPE:
                    return listSI.Where(si => si.type.ToString().Equals(value)).ToList();

                case CommandOption.SI_NAME:
                    return listSI.Where(si => si.informationName.Equals(value)).ToList();

                case CommandOption.SI_CONTAINER:
                    return listSI.Where(si => si.containerName.Equals(value)).ToList();

                case CommandOption.SI_NOTES:
                    return listSI.Where(si => si.notes.Equals(value)).ToList();

                case CommandOption.SI_USERNAME:
                    return listSI.Where(si => si.username.Equals(value)).ToList();

                case CommandOption.SI_PASSWORD:
                    return listSI.Where(si => si.password.Equals(value)).ToList();

                case CommandOption.SI_CARD_NAME:
                    return listSI.Where(si => si.cardName.Equals(value)).ToList();

                case CommandOption.SI_CARD_ENTITY:
                    return listSI.Where(si => si.cardEntity.Equals(value)).ToList();

                case CommandOption.SI_CARD_NUMBER:
                    return listSI.Where(si => si.cardNumber.Equals(value)).ToList();

                case CommandOption.SI_CARD_EXP_DATE:
                    return listSI.Where(si => si.cardExpirationDate.Equals(value)).ToList();

                case CommandOption.SI_CARD_SECURITY_NUMBER:
                    return listSI.Where(si => si.cardSecurityNumber.Equals(value)).ToList();

                case CommandOption.SI_CONTACT_NAME:
                    return listSI.Where(si => si.contactName.Equals(value)).ToList();

                case CommandOption.SI_CONTACT_LAST_NAME:
                    return listSI.Where(si => si.contactLastname.Equals(value)).ToList();

                case CommandOption.SI_BUSSINES_NAME:
                    return listSI.Where(si => si.businessName.Equals(value)).ToList();

                case CommandOption.SI_POSTAL_CODE:
                    return listSI.Where(si => si.postalCode.Equals(value)).ToList();

                case CommandOption.SI_COUNTRY:
                    return listSI.Where(si => si.country.Equals(value)).ToList();

                case CommandOption.SI_STATE:
                    return listSI.Where(si => si.state.Equals(value)).ToList();

                case CommandOption.SI_BIRTHDAY:
                    return listSI.Where(si => si.birthday.Equals(value)).ToList();

                case CommandOption.SI_FAVORITE:
                    return listSI.Where(si => si.favorite).ToList();

                case CommandOption.SI_CONTENT_KEY:
                    return listSI.Where(si => si.contentKey.Equals(value)).ToList();

                case CommandOption.SI_URLS_LIST:
                    var listToSearchUrl = new List<string>(value.Split(sign));
                    return listSI.Where(si => si.urlsList.Any(url => listToSearchUrl.Contains(url))).ToList();

                case CommandOption.SI_TAGS_LIST:
                    var listToSearchTag = new List<string>(value.Split(sign));
                    return listSI.Where(si => si.tagsList.Any(tag => listToSearchTag.Contains(tag))).ToList();

                case CommandOption.SI_EMAILS_LIST:
                    var listToSearchEmail = new List<string>(value.Split(sign));
                    return listSI.Where(si => si.emailsList.Any(email => listToSearchEmail.Contains(email))).ToList();

                case CommandOption.SI_PHONE_NUMBERS_LIST:
                    var listToSearchPNumber = new List<string>(value.Split(sign));
                    return listSI.Where(si => si.phoneNumbersList.Any(phone => listToSearchPNumber.Contains(phone))).ToList();

                case CommandOption.SI_ADDRESSES_LIST:
                    var listToSearchAdress = new List<string>(value.Split(sign));
                    return listSI.Where(si => si.addressesList.Any(adress => listToSearchAdress.Contains(adress))).ToList();
            }
            return listSI;
        }
    }
}
