using System.Collections.Generic;

namespace SensitiveInformationConsole.Src.Commands
{
    internal class CommandOption
    {
        internal const string SI_TYPE = "-type";
        internal const string SI_NAME = "-namenote";
        internal const string SI_CONTAINER = "-container";
        internal const string SI_NOTES = "-notes";
        internal const string SI_USERNAME = "-username";
        internal const string SI_PASSWORD = "-password";
        internal const string SI_CARD_NAME = "-cardname";
        internal const string SI_CARD_ENTITY = "-cardentity";
        internal const string SI_CARD_NUMBER = "-cardnumber";
        internal const string SI_CARD_EXP_DATE = "-cardexpdate";
        internal const string SI_CARD_SECURITY_NUMBER = "-cardsecuritynumber";
        internal const string SI_CONTACT_NAME = "-contactname";
        internal const string SI_CONTACT_LAST_NAME = "-contactlastname";
        internal const string SI_BUSSINES_NAME = "-bussinesname";
        internal const string SI_POSTAL_CODE = "-postalcode";
        internal const string SI_COUNTRY = "-country";
        internal const string SI_STATE = "-state";
        internal const string SI_BIRTHDAY = "-birthday";
        internal const string SI_FAVORITE = "-favorite";
        internal const string SI_CONTENT_KEY = "-contentkey";
        internal const string SI_URLS_LIST = "-urlslist";
        internal const string SI_TAGS_LIST = "-tagslist";
        internal const string SI_EMAILS_LIST = "-emailslist";
        internal const string SI_PHONE_NUMBERS_LIST = "-phoneslist";
        internal const string SI_ADDRESSES_LIST = "-addresseslist";
        internal readonly static List<string> listCommandOption = new List<string>()
        {
            SI_TYPE,
            SI_NAME,
            SI_CONTAINER,
            SI_NOTES,
            SI_USERNAME,
            SI_PASSWORD,
            SI_CARD_NAME,
            SI_CARD_ENTITY,
            SI_CARD_NUMBER,
            SI_CARD_EXP_DATE,
            SI_CARD_SECURITY_NUMBER,
            SI_CONTACT_NAME,
            SI_CONTACT_LAST_NAME,
            SI_BUSSINES_NAME,
            SI_POSTAL_CODE,
            SI_COUNTRY,
            SI_STATE,
            SI_BIRTHDAY,
            SI_FAVORITE,
            SI_CONTENT_KEY,
            SI_URLS_LIST,
            SI_TAGS_LIST,
            SI_EMAILS_LIST,
            SI_PHONE_NUMBERS_LIST,
            SI_ADDRESSES_LIST
        };

        private CommandOption()
        {
        }
    }
}
