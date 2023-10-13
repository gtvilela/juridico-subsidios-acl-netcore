using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Mocks;
using Juridico.Subsidios.Acl.Domain.Models.EnvioFornecedor;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public class InformacaoAdicionalService : IInformacaoAdicionalService
    {
        private readonly IFornecedorGateway fornecedorGateway;
        private readonly IMapper mapper;

        public InformacaoAdicionalService(IFornecedorGateway fornecedorGateway, IMapper mapper)
        {
            this.fornecedorGateway = fornecedorGateway;
            this.mapper = mapper;
        }

        public async Task<InformacaoAdicionalFornecedorRetornoModel> ObterInformacoesAdicionais(string processo)
        {
            var infoAddFiltro = new InformacesAdicionaisFiltro(processo);

            var retornoInformacoesAdicionais = await fornecedorGateway.ExecuteAsync<InformacesAdicionaisFiltro, InformacaoAdicionalFornecedorRetornoModel>(infoAddFiltro, FornecedorMock.XML_RETORNO_CONSULTA_SEM_INFORMACOES_ADICIONAIS);
            if (retornoInformacoesAdicionais is null)
            {
                retornoInformacoesAdicionais = new InformacaoAdicionalFornecedorRetornoModel();
                retornoInformacoesAdicionais.AddNotification("Erro", $"Não foi possível obter as informações adicionais do processo {processo}");
            }
            return retornoInformacoesAdicionais;
        }

        public async Task<InformacaoAdicionalFornecedorRetornoModel> ObterRetornoComInformacoesAdicionais(string processo)
        {
            var infoAddFiltro = new InformacesAdicionaisFiltro(processo);

            var retornoInformacoesAdicionais = await fornecedorGateway.ExecuteAsync<InformacesAdicionaisFiltro, InformacaoAdicionalFornecedorRetornoModel>(infoAddFiltro, FornecedorMock.XML_RETORNO_CONSULTA_COM_INFORMACOES_ADICIONAIS);
            if (retornoInformacoesAdicionais is null)
            {
                retornoInformacoesAdicionais = new InformacaoAdicionalFornecedorRetornoModel();
                retornoInformacoesAdicionais.AddNotification("Erro", $"Não foi possível obter as informações adicionais do processo {processo}");
            }
            return retornoInformacoesAdicionais;
        }

        public async Task<InsercaoRetornoModel> InserirInformacaoAdicional(InformacaoAdicionalModel informacaoAdicional)
        {
            var informacaoAdicionalMap = mapper.Map<InformacaoAdicionalFornecedorEnvioModel>(informacaoAdicional);
            var retornoinformacaoAdicional = await fornecedorGateway.ExecuteAsync<InformacaoAdicionalFornecedorEnvioModel, InsercaoRetornoModel>(informacaoAdicionalMap, FornecedorMock.XML_RETORNO_INCLUSAO_INFORMACAO_ADICIONAL);
            retornoinformacaoAdicional.Informacao = $"Informação Adicional: {informacaoAdicional.Valor} | Processo: {informacaoAdicional.CodigoProcesso}";
            return retornoinformacaoAdicional;
        }
    }
}
