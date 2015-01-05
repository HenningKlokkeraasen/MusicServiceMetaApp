using Msma.Domain.Dtos;
using Msma.Domain.Enums;

namespace MusicServiceMetaApp.Web.Orchestrators
{
    internal abstract class OrchestratroBase
    {
        protected T SetSoruce<T>(T dto, SourceEnum source)
            where T: DtoBase
        {
            dto.Source = source;
            return dto;
        }
    }
}