using Juridico.Subsidios.Acl.Domain.Extensions;
using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Juridico.Nucleo.Subsidios.Application.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    
    public class SubsidioController : ApiBaseController<SubsidioController>
    {
        private readonly ISubsidiosHandler subsidiosHandler;
        private readonly IConfigCatService configCatService;
        public SubsidioController(ILogger<SubsidioController> logger, 
                                  ISubsidiosHandler subsidiosHandler,
                                  IConfigCatService configCatService) : base(logger)
        {
            this.subsidiosHandler = subsidiosHandler;
            this.configCatService = configCatService;
        }

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(SubsidioModel))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Busca os subs�dios relacionados ao processo informado.")]
        public async Task<IActionResult> BuscarSubsidios([FromBody] SubsidioModel subsidio)
        {
            if (string.IsNullOrEmpty(subsidio.Contrato) && string.IsNullOrEmpty(subsidio.Placa))
                return BadRequest("Ao menos uma das informa��es (Placa ou Contrato) deve ser informada.");

            subsidio.MateriaLegal = subsidio.MateriaLegal.RetirarAcentuacaoMateriaLegal();
            var subsidios = subsidiosHandler.ProcessarSubsidios(subsidio);
            Console.WriteLine($"Informa��es enviadas com sucesso. Subs�dios do processo {subsidio.CodigoProcesso} ser�o enviados � plataforma do fornecedor.");
            return Ok(subsidios);
        }

        [HttpPost("{informacaoAdicional}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Busca o c�digo das informa��es adicionais do fornecedor.")]
        public async Task<IActionResult> BuscarCodigoInformacaoAdicional(string informacaoAdicional)
        {
            if (string.IsNullOrEmpty(informacaoAdicional))
                return BadRequest("Informa��o adicional n�o pode ser nulo");

            var retorno = configCatService.BuscarCodigoInformacaoAdicional(informacaoAdicional);
            
            if(retorno is null)
            {
                return BadRequest($"A informa��o adicional {informacaoAdicional} n�o foi encontrada");
            }
            return Ok(retorno);
        }
    }
}