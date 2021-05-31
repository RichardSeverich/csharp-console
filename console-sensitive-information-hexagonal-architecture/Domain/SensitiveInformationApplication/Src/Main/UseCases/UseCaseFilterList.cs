using SensitiveInformationCore.Src.Main.EntityDomain;
using System.Collections.Generic;
using System.Linq;

namespace SensitiveInformationApplication.Src.Main.UseCases
{
    public static class UseCaseFilterList
    {
        private const string sign = ",";

        public static List<SensitiveInformation> FilterByUuid(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.uuid.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterById(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.id.ToString().Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByType(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.type.ToString().Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByName(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.informationName.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByContainerName(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.containerName.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByNotes(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.notes.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByUsername(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.username.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByPassword(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.password.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByCardName(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.cardName.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByCardEntity(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.cardEntity.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByCardNumber(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.cardNumber.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByCardExpirationDate(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.cardExpirationDate.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByCardSecurityNumber(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.cardSecurityNumber.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByContactName(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.contactName.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByContactLastname(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.contactLastname.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByBusinessName(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.businessName.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByPostalCode(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.postalCode.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByCountry(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.country.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByState(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.state.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByBirthday(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.birthday.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByFavorite(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.favorite).ToList();
        }

        public static List<SensitiveInformation> FilterByContentKey(List<SensitiveInformation> listSI, string value)
        {
            return listSI.Where(si => si.contentKey.Equals(value)).ToList();
        }

        public static List<SensitiveInformation> FilterByUrlsList(List<SensitiveInformation> listSI, string value)
        {
            var listToSearchUrl = new List<string>(value.Split(sign));
            return listSI.Where(si => si.urlsList.Any(url => listToSearchUrl.Contains(url))).ToList();
        }

        public static List<SensitiveInformation> FilterByTagsList(List<SensitiveInformation> listSI, string value)
        {
            var listToSearchTag = new List<string>(value.Split(sign));
            return listSI.Where(si => si.tagsList.Any(tag => listToSearchTag.Contains(tag))).ToList();
        }

        public static List<SensitiveInformation> FilterByEmailsList(List<SensitiveInformation> listSI, string value)
        {
            var listToSearchEmail = new List<string>(value.Split(sign));
            return listSI.Where(si => si.emailsList.Any(email => listToSearchEmail.Contains(email))).ToList();
        }

        public static List<SensitiveInformation> FilterByPhoneNumbersList(List<SensitiveInformation> listSI, string value)
        {
            var listToSearchPNumber = new List<string>(value.Split(sign));
            return listSI.Where(si => si.phoneNumbersList.Any(phone => listToSearchPNumber.Contains(phone))).ToList();
        }

        public static List<SensitiveInformation> FilterByAddressesList(List<SensitiveInformation> listSI, string value)
        {
            var listToSearchAdress = new List<string>(value.Split(sign));
            return listSI.Where(si => si.addressesList.Any(adress => listToSearchAdress.Contains(adress))).ToList();
        }
    }
}
