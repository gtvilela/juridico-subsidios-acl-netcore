using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public interface IInformacaoAdicionalService
    {
        Task<InformacaoAdicionalFornecedorRetornoModel> ObterInformacoesAdicionais(string processo);
        Task<InformacaoAdicionalFornecedorRetornoModel> ObterRetornoComInformacoesAdicionais(string processo);
        Task<InsercaoRetornoModel> InserirInformacaoAdicional(InformacaoAdicionalModel informacaoAdicional);
    }
}