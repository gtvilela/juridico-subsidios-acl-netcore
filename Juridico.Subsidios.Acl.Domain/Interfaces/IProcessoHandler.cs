using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Domain.Interfaces
{
    public interface IProcessoHandler
    {
        Task<DocumentosFornecedorModel> ObterDocumentos(string processo);
        Task<InformacaoAdicionalFornecedorModel> ObterInformacoesAdicionais(string processo);
        Task<ProcessoModel> ObterProcesso(string processo);
    }
}