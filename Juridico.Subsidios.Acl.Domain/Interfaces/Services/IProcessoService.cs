using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public interface IProcessoService
    {
        Task<ProcessoFornecedorRetornoModel> ObterProcesso(string processo);
    }
}