using Microsoft.AspNetCore.Mvc;
using SensitiveInformationAPI.Dto;
using System.Collections.Generic;
using System.Linq;
using SensitiveInformationAPI.Containers;
using SensitiveInformationCore.Src.Main.EntityDomain;
using SensitiveInformationCore.Src.Main.Converts;
using System;

namespace SensitiveInformationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SensitiveInformationController
    {
        public SensitiveInformationController()
        {
        }

        [HttpGet()]
        public IEnumerable<SensitiveInformationDto> GetAll()
        {
            return ContainerUseCase.getUseCaseCrud().Read()
                .Select(si => SensitiveInformationDto.FromEntityToDto(si));
        }

        [HttpPost()]
        public string Post([FromBody] SensitiveInformationDto sensitiveInformationDTO)
        {
            ContainerUseCase.getUseCaseCrud().Create(sensitiveInformationDTO.FromDtoToEntityDomain());
            return "Created";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            ContainerUseCase.getUseCaseCrud().Delete(id);
            return "Deleted";
        }

        [HttpPut("{id}")]
        public string Update(int id, [FromBody] SensitiveInformationDto siDto)
        {
            List <SensitiveInformation> listSI = ContainerUseCase.getUseCaseCrud().Read();
            SensitiveInformation modelSI = listSI.Find(si => si.id == id);
            if (modelSI == null)
            {
                return "Not found";
            }

            if (siDto.Type != null)
            {
                modelSI.type = ConvertStringToEnum<EnumSIType>.Convert(siDto.Type);
            }
            if (siDto.InformationName != null)
            {
                modelSI.informationName = siDto.InformationName;
            }
            if (siDto.ContainerName != null)
            {
                modelSI.containerName = siDto.ContainerName;
            }
            if (siDto.Notes != null)
            {
                modelSI.notes = siDto.Notes;
            }
            if (siDto.Username != null)
            {
                modelSI.username = siDto.Username;
            }
            if (siDto.Password != null)
            {
                modelSI.password = siDto.Password;
            }
            if (siDto.CardName != null)
            {
                modelSI.cardName = siDto.CardName;
            }
            if (siDto.CardEntity != null)
            {
                modelSI.cardEntity = siDto.CardEntity;
            }
            if (siDto.CardNumber != null)
            {
                modelSI.cardNumber = siDto.CardNumber;
            }
            if (siDto.CardExpirationDate != default(DateTime))
            {
                modelSI.cardExpirationDate = siDto.CardExpirationDate;
            }
            if (siDto.CardSecurityNumber != 0)
            {
                modelSI.cardSecurityNumber = siDto.CardSecurityNumber;
            }
            if (siDto.ContactName != null)
            {
                modelSI.contactName = siDto.ContactName;
            }
            if (siDto.ContactLastname != null)
            {
                modelSI.contactLastname = siDto.ContactLastname;
            }
            if (siDto.BusinessName != null)
            {
                modelSI.businessName = siDto.BusinessName;
            }
            if (siDto.PostalCode != 0)
            {
                modelSI.postalCode = siDto.PostalCode;
            }
            if (siDto.Country != null)
            {
                modelSI.country = siDto.Country;
            }
            if (siDto.State != null)
            {
                modelSI.state = siDto.State;
            }
            if (siDto.Birthday != default(DateTime))
            {
                modelSI.birthday = siDto.Birthday;
            }
            if (siDto.Favorite)
            {
                modelSI.favorite = siDto.Favorite;
            }
            if (siDto.ContentKey != null)
            {
                modelSI.contentKey = siDto.ContentKey;
            }
            if (siDto.UrlsList != null && siDto.UrlsList.Any())
            {
                modelSI.urlsList = siDto.UrlsList;
            }
            if (siDto.TagsList != null && siDto.TagsList.Count > 0)
            {
                modelSI.tagsList = siDto.TagsList;
            }
            if (siDto.EmailsList != null && siDto.EmailsList.Any())
            {
                modelSI.emailsList = siDto.EmailsList;
            }
            if (siDto.PhoneNumbersList != null && siDto.PhoneNumbersList.Any())
            {
                modelSI.phoneNumbersList = siDto.PhoneNumbersList;
            }
            if (siDto.AddressesList != null && siDto.AddressesList.Any())
            {
                modelSI.addressesList = siDto.AddressesList;
            }
            ContainerUseCase.getUseCaseCrud().Update(id, modelSI);
            return "Updated";
        }
    }
}
