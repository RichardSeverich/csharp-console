using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using SensitiveInformationCore.Src.Main.Converts;

namespace SensitiveInformationCore.Src.Main.Models
{
    public class ModelSensitiveInformation
    {
        public int id;
        public string uuid;
        public EnumSIType type;
        public string informationName;
        public string containerName;
        public string notes;
        public string username;
        public string password;
        public string cardName;
        public string cardEntity;
        public string cardNumber;
        public DateTime cardExpirationDate;
        public int cardSecurityNumber;
        public string contactName;
        public string contactLastname;
        public string businessName;
        public int postalCode;
        public string country;
        public string state;
        public DateTime birthday;
        public bool favorite;
        public string contentKey;
        public List<string> urlsList;
        public List<string> tagsList;
        public List<string> emailsList;
        public List<string> phoneNumbersList;
        public List<string> addressesList;

        public ModelSensitiveInformation()
        {
            type = EnumSIType.note;
            informationName = "none";
            containerName = "folder";
            notes = "none";
            username = "none";
            cardName = "none";
            cardEntity = "none";
            cardNumber = "none";
            cardSecurityNumber = 0;
            contactName = "none";
            contactLastname = "none";
            businessName = "none";
            postalCode = 0;
            country = "none";
            state = "none";
            favorite = false;
            contentKey = "none";
            urlsList = new List<string>();
            tagsList = new List<string>();
            emailsList = new List<string>();
            phoneNumbersList = new List<string>();
            addressesList = new List<string>();
        }

        public string ToStringJson()
        {
            string json = ConvertObjectToStringJsonIdent<ModelSensitiveInformation>.Convert(this);
            json = Regex.Replace(json, "\"type\": [0-9]", "\"type\": " + type.ToString());

            return json;
        }
    }
}
