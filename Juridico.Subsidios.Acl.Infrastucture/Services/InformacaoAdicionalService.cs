using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Mocks;
using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public class InformacaoAdicionalService : IInformacaoAdicionalService
    {
        private readonly IFornecedorGateway fornecedorGateway;

        public InformacaoAdicionalService(IFornecedorGateway fornecedorGateway)
        {
            this.fornecedorGateway = fornecedorGateway;
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
    }
}
