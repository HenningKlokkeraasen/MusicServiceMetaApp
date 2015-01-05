using Msma.Domain.Dtos;

namespace MusicServiceMetaApp.Web.Orchestrators
{
    internal abstract class OrchestratroBase
    {
        protected T SetSoruce<T>(T dto, string source)
            where T: DtoBase
        {
            dto.Source = source;
            return dto;
        }
    }
}