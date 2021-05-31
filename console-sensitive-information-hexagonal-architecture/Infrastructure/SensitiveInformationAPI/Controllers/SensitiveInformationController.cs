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

        /*[HttpPost()]
        public IEnumerable<SensitiveInformationDto> Filter([FromBody] SensitiveInformationDto filter)
        {
            List<SensitiveInformation> list = ContainerUseCase.getUseCaseCrud().Read();
            if (filter.Uuid != null)
            {
                list = UseCaseFilterList.FilterByUuid(list, filter.Uuid);
            }
            
            return list.Select(si => SensitiveInformationDto.FromEntityToDto(si));
        }*/

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            ContainerUseCase.getUseCaseCrud().Delete(id);
            return "Deleted";
        }

        [HttpPut("{id}")]
        public string Update(int id, [FromBody] SensitiveInformationDto sensitiveInformationDTO)
        {
            ContainerUseCase.getUseCaseCrud().Update(id, sensitiveInformationDTO.FromDtoToEntityDomain());
            return "Updated";
        }
    }
}
