using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Models;
using Newtonsoft.Json;

namespace Juridico.Subsidios.Acl.Domain.Handlers
{
    public class SubsidiosHandler : ISubsidiosHandler
    {

        /// <summary>
        /// Processo Handler
        /// </summary>
        private readonly IProcessoHandler processoHandler;
        private readonly IConfigCatService configCatService;

        public SubsidiosHandler(IProcessoHandler processoHandler, IConfigCatService configCatService)
        {
            this.processoHandler = processoHandler;
            this.configCatService = configCatService;
        }

        public async Task<SubsidioRetornoModel> ProcessarSubsidios(SubsidioModel subsidio)
        {
            var processo = await processoHandler.ObterProcesso(subsidio.CodigoProcesso);

            var documentosPorMateriaLegal = configCatService.BuscarSiglasDocumento(subsidio.MateriaLegal);
            
            var documentosTratados = JsonConvert.DeserializeObject<List<string>>(documentosPorMateriaLegal);

            var retornoSubsidios = new SubsidioRetornoModel(subsidio.Contrato,
                                                            subsidio.Placa,
                                                            documentosTratados,
                                                            processo);

            return retornoSubsidios;
        }
    }
}
