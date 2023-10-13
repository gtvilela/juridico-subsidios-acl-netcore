using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public interface IInformacaoAdicionalService
    {
        Task<InformacaoAdicionalFornecedorRetornoModel> ObterInformacoesAdicionais(string processo);
    }
}