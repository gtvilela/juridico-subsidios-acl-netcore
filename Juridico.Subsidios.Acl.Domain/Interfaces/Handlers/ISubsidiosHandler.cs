using Juridico.Subsidios.Acl.Domain.Models;

namespace Juridico.Subsidios.Acl.Domain.Interfaces.Handlers
{
    public interface ISubsidiosHandler
    {
        Task<SubsidioRetornoModel> ProcessarSubsidios(SubsidioModel subsidio);
    }
}