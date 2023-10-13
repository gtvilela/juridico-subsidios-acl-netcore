using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Juridico.Nucleo.Subsidios.Application.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]

    public class ProcessoController : ApiBaseController<ProcessoController>
    {
        private readonly IProcessoHandler subsidiosHandler;
        public ProcessoController(ILogger<ProcessoController> logger, IProcessoHandler subsidiosHandler) : base(logger)
        {
            this.subsidiosHandler = subsidiosHandler;
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ProcessoModel))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Obtém as informações do processo referente.")]
        public async Task<IActionResult> Get(string processo)
        {
            var retornoProcesso = await subsidiosHandler.ProcessarSubsidios(processo);

            return Ok(retornoProcesso);
        }
    }
}