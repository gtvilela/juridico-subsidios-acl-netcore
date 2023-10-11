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

        [HttpPost("{informacaoAdicional}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Busca o código das informações adicionais do fornecedor.")]
        public async Task<IActionResult> BuscarCodigoInformacaoAdicional(string informacaoAdicional)
        {
            if (string.IsNullOrEmpty(informacaoAdicional))
                return BadRequest("Informação adicional não pode ser nulo");

            var retorno = configCatService.BuscarCodigoInformacaoAdicional(informacaoAdicional);
            
            if(retorno is null)
            {
                return BadRequest($"A informação adicional {informacaoAdicional} não foi encontrada");
            }
            return Ok(retorno);
        }
    }
}