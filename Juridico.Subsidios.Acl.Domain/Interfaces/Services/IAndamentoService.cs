using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public interface IAndamentoService
    {
        Task<InsercaoRetornoModel> InserirAndamento(AndamentoModel andamento);
    }
}