using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Infrastucture.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Juridico.Nucleo.Subsidios.Application.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    
    public class InformacaoAdicionalController : ApiBaseController<InformacaoAdicionalController>
    {
        private readonly IInformacaoAdicionalService informacaoAdicionalService;
        public InformacaoAdicionalController(ILogger<InformacaoAdicionalController> logger,
                                  IInformacaoAdicionalService informacaoAdicionalService) : base(logger)
        {
            this.informacaoAdicionalService = informacaoAdicionalService;
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Inserir informação adicional do processo no sistema do fornecedor.")]
        public async Task<IActionResult> InserirInformacaoAdicional([FromBody] InformacaoAdicionalModel informacaoAdicional)
        {

            var retorno = await informacaoAdicionalService.InserirInformacaoAdicional(informacaoAdicional);
            
            return Ok($"{retorno.Mensagem} | {retorno.Informacao}");
        }
    }
}