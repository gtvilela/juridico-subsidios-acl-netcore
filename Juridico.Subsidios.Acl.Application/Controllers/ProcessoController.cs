using Juridico.Subsidios.Acl.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Juridico.Nucleo.Subsidios.Application.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]

    public class ProcessoController : ApiBaseController<ProcessoController>
    {
        public ProcessoController(ILogger<ProcessoController> logger) : base(logger)
        {
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Cadastra um novo processo no sistema do fornecedor")]
        public async Task<IActionResult> Post([FromBody] ProcessoModel processo)
        {
            //Chamar o handler

            return Ok();
        }

        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ProcessoModel))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Obtém as informações do processo referente.")]
        public async Task<IActionResult> Get(string processo)
        {
            //Chamar o handler

            return Ok();
        }

        [HttpPatch]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(ProcessoModel))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Atualiza as informações do processo referente")]
        public async Task<IActionResult> Update([FromBody] ProcessoModel processo)
        {
            if (string.IsNullOrEmpty(processo.Codigo))
                return BadRequest("Código do processo não pode ser nulo");
            //Chamar o handler

            return Ok();
        }


    }
}