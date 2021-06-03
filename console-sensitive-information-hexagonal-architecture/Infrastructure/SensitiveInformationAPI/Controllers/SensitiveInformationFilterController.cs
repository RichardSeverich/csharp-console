using System;
using Microsoft.AspNetCore.Mvc;
using SensitiveInformationAPI.Dto;
using System.Collections.Generic;
using System.Linq;
using SensitiveInformationAPI.Containers;
using SensitiveInformationCore.Src.Main.EntityDomain;
using SensitiveInformationApplication.Src.Main.UseCases;

namespace SensitiveInformationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SensitiveInformationFilterController
    {
        public SensitiveInformationFilterController()
        {
        }

        [HttpPost()]
        public IEnumerable<SensitiveInformationDto> Filter([FromBody] SensitiveInformationDto filter)
        {
            List<SensitiveInformation> list = ContainerUseCase.getUseCaseCrud().Read();
            if (filter.Uuid != null)
            {
                list = UseCaseFilterList.FilterByUuid(list, filter.Uuid);
            }
            if (filter.Id != 0)
            {
                list = UseCaseFilterList.FilterById(list, filter.Id.ToString());
            }
            if (filter.Type != null)
            {
                list = UseCaseFilterList.FilterByType(list, filter.Type);
            }
            if (filter.InformationName != null)
            {
                list = UseCaseFilterList.FilterByName(list, filter.InformationName);
            }
            if (filter.ContainerName != null)
            {
                list = UseCaseFilterList.FilterByContainerName(list, filter.ContainerName);
            }
            if (filter.Notes != null)
            {
                list = UseCaseFilterList.FilterByNotes(list, filter.Notes);
            }
            if (filter.Username != null)
            {
                list = UseCaseFilterList.FilterByUsername(list, filter.Username);
            }
            if (filter.Password != null)
            {
                list = UseCaseFilterList.FilterByPassword(list, filter.Password);
            }
            if (filter.CardName != null)
            {
                list = UseCaseFilterList.FilterByCardName(list, filter.CardName);
            }
            if (filter.CardEntity != null)
            {
                list = UseCaseFilterList.FilterByCardEntity(list, filter.CardEntity);
            }
            if (filter.CardNumber != null)
            {
                list = UseCaseFilterList.FilterByCardNumber(list, filter.CardNumber);
            }
            if (filter.CardExpirationDate != default(DateTime))
            {
                list = UseCaseFilterList.FilterByCardExpirationDate(list, filter.CardExpirationDate.ToString());
            }
            if (filter.CardSecurityNumber != 0)
            {
                list = UseCaseFilterList.FilterByUuid(list, filter.CardSecurityNumber.ToString());
            }
            if (filter.ContactName != null)
            {
                list = UseCaseFilterList.FilterByContactName(list, filter.ContactName);
            }
            if (filter.ContactLastname != null)
            {
                list = UseCaseFilterList.FilterByContactLastname(list, filter.ContactLastname);
            }
            if (filter.BusinessName != null)
            {
                list = UseCaseFilterList.FilterByBusinessName(list, filter.BusinessName);
            }
            if (filter.PostalCode != 0)
            {
                list = UseCaseFilterList.FilterByPostalCode(list, filter.PostalCode.ToString());
            }
            if (filter.Country != null)
            {
                list = UseCaseFilterList.FilterByCountry(list, filter.Country);
            }
            if (filter.State != null)
            {
                list = UseCaseFilterList.FilterByState(list, filter.State);
            }
            if (filter.Birthday != default(DateTime))
            {
                list = UseCaseFilterList.FilterByBusinessName(list, filter.Birthday.ToString());
            }
            if (filter.Favorite)
            {
                list = UseCaseFilterList.FilterByFavorite(list);
            }
            if (filter.ContentKey != null)
            {
                list = UseCaseFilterList.FilterByContentKey(list, filter.ContentKey);
            }
            if (filter.UrlsList != null && filter.UrlsList.Any())
            {
                list = UseCaseFilterList.FilterByUrlsList(list, filter.UrlsList);
            }
            if (filter.TagsList != null && filter.TagsList.Count > 0)
            {
                list = UseCaseFilterList.FilterByTagsList(list, filter.TagsList);
            }
            if (filter.EmailsList != null && filter.EmailsList.Any())
            {
                list = UseCaseFilterList.FilterByEmailsList(list, filter.EmailsList);
            }
            if (filter.PhoneNumbersList != null && filter.PhoneNumbersList.Any())
            {
                list = UseCaseFilterList.FilterByPhoneNumbersList(list, filter.PhoneNumbersList);
            }
            if (filter.AddressesList != null && filter.AddressesList.Any())
            {
                list = UseCaseFilterList.FilterByAddressesList(list, filter.AddressesList);
            }

            return list.Select(si => SensitiveInformationDto.FromEntityToDto(si));
        }
    }
}
