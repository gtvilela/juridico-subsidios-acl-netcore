using Juridico.Subsidios.Acl.Domain.Interfaces.Handlers;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Infrastucture.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Juridico.Nucleo.Subsidios.Application.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]

    public class ProcessoController : ApiBaseController<ProcessoController>
    {
        private readonly IProcessoHandler subsidiosHandler;
        private readonly IInformacaoAdicionalService informacaoAdicionalService;
        private readonly IDocumentoService documentoService;
        private readonly IAndamentoService andamentoService;
        public ProcessoController(ILogger<ProcessoController> logger, 
                                  IProcessoHandler subsidiosHandler,
                                  IInformacaoAdicionalService informacaoAdicionalService,
                                  IDocumentoService documentoService,
                                  IAndamentoService andamentoService) : base(logger)
        {
            this.subsidiosHandler = subsidiosHandler;
            this.informacaoAdicionalService = informacaoAdicionalService;
            this.documentoService = documentoService;
            this.andamentoService = andamentoService;
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

        [HttpPost("InformacaoAdicional")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Inserir informação adicional do processo no sistema do fornecedor.")]
        public async Task<IActionResult> InserirInformacaoAdicional([FromBody] InformacaoAdicionalModel informacaoAdicional)
        {

            var retorno = await informacaoAdicionalService.InserirInformacaoAdicional(informacaoAdicional);

            return Ok($"{retorno.Mensagem} | {retorno.Informacao}");
        }


        [HttpPost("Documento")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Inserir documento do processo no sistema do fornecedor.")]
        public async Task<IActionResult> InserirDocumento([FromBody] DocumentoModel documento)
        {
            var retorno = await documentoService.InserirDocumento(documento);

            return Ok($"{retorno.Mensagem} | {retorno.Informacao}");
        }

        [HttpPost("Andamento")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Inserir andamento do processo no sistema do fornecedor.")]
        public async Task<IActionResult> InserirAndamento([FromBody] AndamentoModel andamento)
        {
            var retorno = await andamentoService.InserirAndamento(andamento);

            return Ok($"{retorno.Mensagem} | {retorno.Informacao}");
        }
    }
}