using Juridico.Subsidios.Acl.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Acl.Domain.Mocks;
using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public class ProcessoService : IProcessoService
    {
        private readonly IFornecedorGateway fornecedorGateway;

        public ProcessoService(IFornecedorGateway fornecedorGateway)
        {
            this.fornecedorGateway = fornecedorGateway;
        }

        public async Task<ProcessoFornecedorRetornoModel> ObterProcesso(string processo)
        {
            var processoFiltro = new ProcessoFiltro(processo);

            var processoFornecedor = await fornecedorGateway.ExecuteAsync<ProcessoFiltro, ProcessoFornecedorRetornoModel>(processoFiltro, FornecedorMock.XML_RETORNO_CONSULTA_PROCESSO);
            if (processoFornecedor is null)
            {
                processoFornecedor = new ProcessoFornecedorRetornoModel();
                processoFornecedor.AddNotification("Erro", $"Não foi possível obter os dados do processo {processo}");
            }
            return processoFornecedor;
        }
    }
}
