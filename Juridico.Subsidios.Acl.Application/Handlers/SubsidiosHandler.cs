using Juridico.Subsidios.Acl.Domain.Interfaces.Handlers;
using Juridico.Subsidios.Acl.Domain.Interfaces.Services;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.CheckModels;
using Juridico.Subsidios.Acl.Infrastucture.Services;

namespace Juridico.Subsidios.Acl.Application.Handlers
{
    public class SubsidiosHandler : ISubsidiosHandler
    {
        private readonly IProcessoHandler processoHandler;
        private readonly IConfigCatService configCatService;
        private readonly IRabbitMqService rabbitMqService;

        public SubsidiosHandler(IProcessoHandler processoHandler, IConfigCatService configCatService, IRabbitMqService rabbitMqService)
        {
            this.processoHandler = processoHandler;
            this.configCatService = configCatService;
            this.rabbitMqService = rabbitMqService;
        }

        public async Task ProcessarSubsidios(SubsidioModel subsidio)
        {
            var processoCompleto = await processoHandler.ProcessarSubsidios(subsidio.CodigoProcesso);
            var subsidiosCheck = new SubsidiosCheckModel(configCatService, processoCompleto);
            var subsidios = new SubsidioRetornoModel(subsidio.Contrato, subsidio.Placa, subsidiosCheck);

            rabbitMqService.Publish(subsidios,$"fila-juridico-{subsidio.MateriaLegal}");
        }
    }
}
