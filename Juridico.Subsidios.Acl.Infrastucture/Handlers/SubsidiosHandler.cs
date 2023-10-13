using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.CheckModels;

namespace Juridico.Subsidios.Acl.Domain.Handlers
{
    public class SubsidiosHandler : ISubsidiosHandler
    {
        private readonly IProcessoHandler processoHandler;
        private readonly IConfigCatService configCatService;

        public SubsidiosHandler(IProcessoHandler processoHandler, IConfigCatService configCatService)
        {
            this.processoHandler = processoHandler;
            this.configCatService = configCatService;
        }

        public async Task<SubsidioRetornoModel> ProcessarSubsidios(SubsidioModel subsidio)
        {
            var processoCompleto = await processoHandler.ProcessarSubsidios(subsidio.CodigoProcesso);
            var subsidiosCheck = new SubsidiosCheckModel(configCatService, processoCompleto);
            return new SubsidioRetornoModel(subsidio.Contrato, subsidio.Placa, subsidiosCheck);
        }
    }
}
