using Juridico.Subsidios.Acl.Domain.Extensions;
using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Infrastucture.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Juridico.Nucleo.Subsidios.Application.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    
    public class SubsidioController : ApiBaseController<SubsidioController>
    {
        private readonly ISubsidiosHandler subsidiosHandler;
        private readonly IProcessoHandler processoHandler;
        public SubsidioController(ILogger<SubsidioController> logger, 
                                  ISubsidiosHandler subsidiosHandler,
                                  IProcessoHandler processoHandler) : base(logger)
        {
            this.subsidiosHandler = subsidiosHandler;
            this.processoHandler = processoHandler;
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SubsidioModel))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Busca os subsídios relacionados ao processo informado.")]
        public async Task<IActionResult> BuscarSubsidios([FromBody] SubsidioModel subsidio)
        {
            if (string.IsNullOrEmpty(subsidio.Contrato) && string.IsNullOrEmpty(subsidio.Placa))
                return BadRequest("Ao menos uma das informações (Placa ou Contrato) deve ser informada.");

            subsidio.MateriaLegal = subsidio.MateriaLegal.RetirarAcentuacaoMateriaLegal();
            var subsidios = subsidiosHandler.ProcessarSubsidios(subsidio);
            Console.WriteLine($"Informações enviadas com sucesso. Subsídios do processo {subsidio.CodigoProcesso} serão enviados à plataforma do fornecedor.");
            return Ok(subsidios);
        }
    }
}