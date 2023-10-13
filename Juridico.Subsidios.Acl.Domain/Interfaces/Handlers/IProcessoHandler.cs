using Juridico.Subsidios.Acl.Domain.Models;
namespace Juridico.Subsidios.Acl.Domain.Interfaces.Handlers
{
    public interface IProcessoHandler
    {
        Task<ProcessoModel> ProcessarSubsidios(string processo);
    }
}