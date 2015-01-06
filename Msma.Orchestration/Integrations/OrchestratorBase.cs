using Msma.Domain.Dtos;
using Msma.Domain.Enums;

namespace Msma.Orchestration.Integrations
{
    public abstract class OrchestratorBase
    {
        protected T SetSoruce<T>(T dto, SourceEnum source)
            where T: DtoBase
        {
            dto.Source = source;
            return dto;
        }
    }
}