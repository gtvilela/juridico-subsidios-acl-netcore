using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public interface IDocumentoService
    {
        Task<DocumentoFornecedorRetornoModel> ObterDocumentos(string processo);
        Task<DocumentoFornecedorRetornoModel> ObterRetornoComDocumentos(string processo);
        Task<InsercaoRetornoModel> InserirDocumento(DocumentoModel documento);
    }
}