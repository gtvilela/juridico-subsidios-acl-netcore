using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Mocks;
using Juridico.Subsidios.Acl.Domain.Models.EnvioFornecedor;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;
using Juridico.Subsidios.Acl.Domain.Interfaces.Gateways;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public class AndamentoService : IAndamentoService
    {
        private readonly IFornecedorGateway fornecedorGateway;
        private readonly IMapper mapper;

        public AndamentoService(IFornecedorGateway fornecedorGateway, IMapper mapper)
        {
            this.fornecedorGateway = fornecedorGateway;
            this.mapper = mapper;
        }

        public async Task<InsercaoRetornoModel> InserirAndamento(AndamentoModel andamento)
        {
            var andamentoMap = mapper.Map<AndamentoFornecedorEnvioModel>(andamento);
            var retornoinformacaoAdicional = await fornecedorGateway.ExecuteAsync<AndamentoFornecedorEnvioModel, InsercaoRetornoModel>(andamentoMap, FornecedorMock.XML_RETORNO_INCLUSAO_ANDAMENTO);
            retornoinformacaoAdicional.Informacao = $"Andamento Processamento de Subsídios | Processo: {andamento.CodigoProcesso}";
            return retornoinformacaoAdicional;
        }
    }
}
