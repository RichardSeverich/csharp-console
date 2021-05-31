using SensitiveInformationCore.Src.Main.EntityDomain;
using System;
using System.Collections.Generic;

namespace SensitiveInformationAPI.Dto
{
    public class SensitiveInformationDto
    {
        public int Id { get; set; }

        public string Uuid { get; set; }

        public EnumSIType Type { get; set; }

        public string InformationName { get; set; }

        public string ContainerName { get; set; }

        public string Notes { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string CardName { get; set; }

        public string CardEntity { get; set; }

        public string CardNumber { get; set; }

        public DateTime CardExpirationDate { get; set; }

        public int CardSecurityNumber { get; set; }

        public string ContactName { get; set; }

        public string ContactLastname { get; set; }

        public string BusinessName { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public DateTime Birthday { get; set; }

        public bool Favorite { get; set; }

        public string ContentKey { get; set; }

        public List<string> UrlsList { get; set; }

        public List<string> TagsList { get; set; }

        public List<string> EmailsList { get; set; }

        public List<string> PhoneNumbersList { get; set; }

        public List<string> AddressesList { get; set; }

        public static SensitiveInformationDto FromEntityToDto(SensitiveInformation entityDomain)
        {
            return new SensitiveInformationDto
            {
                Id = entityDomain.id,
                Uuid = entityDomain.uuid,
                Type = entityDomain.type,
                InformationName = entityDomain.informationName,
                ContainerName = entityDomain.containerName,
                Notes = entityDomain.notes,
                Username = entityDomain.username,
                Password = entityDomain.password,
                CardName = entityDomain.cardName,
                CardEntity = entityDomain.cardEntity,
                CardNumber = entityDomain.cardNumber,
                CardExpirationDate = entityDomain.cardExpirationDate,
                CardSecurityNumber = entityDomain.cardSecurityNumber,
                ContactName = entityDomain.contactName,
                ContactLastname = entityDomain.contactLastname,
                BusinessName = entityDomain.businessName,
                PostalCode = entityDomain.postalCode,
                Country = entityDomain.country,
                State =entityDomain.state,
                Birthday = entityDomain.birthday,
                Favorite = entityDomain.favorite,
                ContentKey = entityDomain.contentKey,
                UrlsList = entityDomain.urlsList,
                TagsList = entityDomain.tagsList,
                EmailsList = entityDomain.emailsList,
                PhoneNumbersList = entityDomain.phoneNumbersList,
                AddressesList = entityDomain.addressesList,
            };
        }

        public SensitiveInformation FromDtoToEntityDomain()
        {
            return new SensitiveInformation
            {
                id = Id,
                uuid = Uuid,
                type = Type,
                informationName = InformationName,
                containerName = ContainerName,
                notes = Notes,
                username = Username,
                password = Password,
                cardName = CardName,
                cardEntity = CardEntity,
                cardNumber = CardNumber,
                cardExpirationDate = CardExpirationDate,
                cardSecurityNumber = CardSecurityNumber,
                contactName = ContactName,
                contactLastname = ContactLastname,
                businessName = BusinessName,
                postalCode = PostalCode,
                country = Country,
                state = State,
                birthday = Birthday,
                favorite = Favorite,
                contentKey = ContentKey,
                urlsList = UrlsList,
                tagsList = TagsList,
                emailsList = EmailsList,
                phoneNumbersList = PhoneNumbersList,
                addressesList = AddressesList,
            };
        }
    }
}
