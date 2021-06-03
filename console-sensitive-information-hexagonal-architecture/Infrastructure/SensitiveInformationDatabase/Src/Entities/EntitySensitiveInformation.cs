using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SensitiveInformationDatabase.Src.Entities
{
    [Table("sensitive_information")]
    public class EntitySensitiveInformation
    {
        [Column("id")]
        public int id;

        [Column("uuid")]
        public Guid uuid;

        [Column("type")]
        public string type;

        [Column("information_name")]
        public string informationName;

        [Column("container_name")]
        public string containerName;

        [Column("notes")]
        public string notes;

        [Column("username")]
        public string username;

        [Column("password")]
        public string password;

        [Column("urls_list")]
        public string urlsList;

        [Column("card_name")]
        public string cardName;

        [Column("card_entity")]
        public string cardEntity;

        [Column("card_number")]
        public string cardNumber;

        [Column("card_expiration_date")]
        public DateTime cardExpirationDate;

        [Column("card_security_number")]
        public int cardSecurityNumber;

        [Column("contact_name")]
        public string contactName;

        [Column("contact_lastname")]
        public string contactLastname;

        [Column("business_name")]
        public string businessName;

        [Column("emails_list")]
        public string emailsList;

        [Column("phone_numbers_list")]
        public string phoneNumbersList;

        [Column("addresses_list")]
        public string addressesList;

        [Column("postal_code")]
        public int postalCode;

        [Column("country")]
        public string country;

        [Column("state")]
        public string state;

        [Column("birthday")]
        public DateTime birthday;

        [Column("tags_list")]
        public string tagsList;

        [Column("favorite")]
        public bool favorite;

        [Column("content_key")]
        public string contentKey;
    }
}
