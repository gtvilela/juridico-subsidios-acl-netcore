using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Acl.Domain.Mocks;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.EnvioFornecedor;
using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public class DocumentoService : IDocumentoService
    {
        private readonly IFornecedorGateway fornecedorGateway;
        private readonly IMapper mapper;

        public DocumentoService(IFornecedorGateway fornecedorGateway, IMapper mapper)
        {
            this.fornecedorGateway = fornecedorGateway;
            this.mapper = mapper;
        }

        public async Task<DocumentoFornecedorRetornoModel> ObterDocumentos(string processo)
        {
            var documentosFiltro = new DocumentosFiltro(processo);

            var retornoDocumentos = await fornecedorGateway.ExecuteAsync<DocumentosFiltro, DocumentoFornecedorRetornoModel>(documentosFiltro, FornecedorMock.XML_RETORNO_CONSULTA_SEM_DOCUMENTOS);
            if (retornoDocumentos is null)
            {
                retornoDocumentos = new DocumentoFornecedorRetornoModel();
                retornoDocumentos.AddNotification("Erro", $"Não foi possível obter as informações adicionais do processo {processo}");
            }
            return retornoDocumentos;
        }

        public async Task<DocumentoFornecedorRetornoModel> ObterRetornoComDocumentos(string processo)
        {
            var documentosFiltro = new DocumentosFiltro(processo);

            var retornoDocumentos = await fornecedorGateway.ExecuteAsync<DocumentosFiltro, DocumentoFornecedorRetornoModel>(documentosFiltro, FornecedorMock.XML_RETORNO_CONSULTA_COM_DOCUMENTOS);
            if (retornoDocumentos is null)
            {
                retornoDocumentos = new DocumentoFornecedorRetornoModel();
                retornoDocumentos.AddNotification("Erro", $"Não foi possível obter as informações adicionais do processo {processo}");
            }
            return retornoDocumentos;
        }

        public async Task<InsercaoRetornoModel> InserirDocumento(DocumentoModel documento)
        {
            var documentoMap = mapper.Map<DocumentoFornecedorEnvioModel>(documento);
            var retornoDocumento = await fornecedorGateway.ExecuteAsync<DocumentoFornecedorEnvioModel,InsercaoRetornoModel>(documentoMap, FornecedorMock.XML_RETORNO_INCLUSAO_DOCUMENTO);
            retornoDocumento.Informacao = $"Documento: {documento.Nome} | Processo: {documento.CodigoProcesso}";
            return retornoDocumento;
        }
    }
}
