using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Mocks;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Handlers
{
    public class ProcessoHandler : IProcessoHandler
    {
        private readonly IFornecedorGateway fornecedorGateway;
        private readonly IMapper mapper;

        public ProcessoHandler(IFornecedorGateway fornecedorGateway, IMapper mapper)
        {
            this.fornecedorGateway = fornecedorGateway;
            this.mapper = mapper;
        }

        public async Task<ProcessoModel> ObterProcesso(string processo)
        {
            #region Buscar dados do processo
            var processoFiltro = new ProcessoFiltro(processo);

            var processoFornecedor = await fornecedorGateway.ExecuteAsync<ProcessoFiltro, ProcessoFornecedorModel>(processoFiltro, FornecedorMock.XML_RETORNO_CONSULTA_PROCESSO);
            if (processoFornecedor is null)
            {
                processoFornecedor = new ProcessoFornecedorModel();
                processoFornecedor.AddNotification("Erro", $"Não foi possível obter os dados do processo {processo}");
            }

            var retornoProcesso = mapper.Map<ProcessoModel>(processoFornecedor);
            retornoProcesso.Codigo = processo;
            retornoProcesso.NumeroProcesso = processo;
            retornoProcesso.ProcessoEletronico = "E" + processo;
            #endregion

            #region Buscar informações adicionais
            var informacoesAdicionaisFornecedor = await ObterInformacoesAdicionais(processo);
            var retornoInformacoesAdicionais = mapper.Map<ProcessoModel>(informacoesAdicionaisFornecedor);
            retornoProcesso.InformacoesAdicionais = retornoInformacoesAdicionais.InformacoesAdicionais;
            #endregion

            #region Buscar documentos
            var documentosFornecedor = await ObterDocumentos(processo);
            var retornoDocumentos = mapper.Map<ProcessoModel>(documentosFornecedor);
            retornoProcesso.Documentos = retornoDocumentos.Documentos;
            #endregion


            return retornoProcesso;

        }

        public async Task<InformacaoAdicionalFornecedorModel> ObterInformacoesAdicionais(string processo)
        {
            var infoAddFiltro = new InformacesAdicionaisFiltro(processo);

            var retornoInformacoesAdicionais = await fornecedorGateway.ExecuteAsync<InformacesAdicionaisFiltro, InformacaoAdicionalFornecedorModel>(infoAddFiltro, FornecedorMock.XML_RETORNO_CONSULTA_INFORMACAO_ADICIONAL);
            if (retornoInformacoesAdicionais is null)
            {
                retornoInformacoesAdicionais = new InformacaoAdicionalFornecedorModel();
                retornoInformacoesAdicionais.AddNotification("Erro", $"Não foi possível obter as informações adicionais do processo {processo}");
            }
            return retornoInformacoesAdicionais;
        }

        public async Task<DocumentosFornecedorModel> ObterDocumentos(string processo)
        {
            var documentosFiltro = new DocumentosFiltro(processo);

            var retornoDocumentos = await fornecedorGateway.ExecuteAsync<DocumentosFiltro, DocumentosFornecedorModel>(documentosFiltro, FornecedorMock.XML_RETORNO_CONSULTA_DOCUMENTO);
            if (retornoDocumentos is null)
            {
                retornoDocumentos = new DocumentosFornecedorModel();
                retornoDocumentos.AddNotification("Erro", $"Não foi possível obter as informações adicionais do processo {processo}");
            }
            return retornoDocumentos;
        }

    }
}
