using Juridico.Subsidios.Acl.Domain.Models;
namespace Juridico.Subsidios.Acl.Domain.Interfaces
{
    public interface IProcessoHandler
    {
        Task<ProcessoModel> ProcessarSubsidios(string processo);
    }
}