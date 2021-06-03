using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using SensitiveInformationCore.Src.Main.Converts;

namespace SensitiveInformationCore.Src.Main.EntityDomain
{
    public class SensitiveInformation
    {
        public int id { get; set; }
        public string uuid { get; set; }
        public EnumSIType type { get; set; }
        public string informationName { get; set; }
        public string containerName { get; set; }
        public string notes { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string cardName { get; set; }
        public string cardEntity { get; set; }
        public string cardNumber { get; set; }
        public DateTime cardExpirationDate { get; set; }
        public int cardSecurityNumber { get; set; }
        public string contactName { get; set; }
        public string contactLastname { get; set; }
        public string businessName { get; set; }
        public int postalCode { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public DateTime birthday { get; set; }
        public bool favorite { get; set; }
        public string contentKey { get; set; }
        public List<string> urlsList { get; set; }
        public List<string> tagsList { get; set; }
        public List<string> emailsList { get; set; }
        public List<string> phoneNumbersList { get; set; }
        public List<string> addressesList { get; set; }

        public SensitiveInformation()
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
            string json = ConvertObjectToStringJsonIdent<SensitiveInformation>.Convert(this);
            json = Regex.Replace(json, "\"type\": [0-9]", "\"type\": " + type.ToString());

            return json;
        }
    }
}
