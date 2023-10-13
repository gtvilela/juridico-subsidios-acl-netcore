using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Infrastucture.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Juridico.Nucleo.Subsidios.Application.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    
    public class DocumentoController : ApiBaseController<DocumentoController>
    {
        private readonly IDocumentoService documentoService;
        public DocumentoController(ILogger<DocumentoController> logger, 
                                  IDocumentoService documentoService) : base(logger)
        {
            this.documentoService = documentoService;
        } 

        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [SwaggerResponse(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        [SwaggerOperation(Summary = "Inserir documento do processo no sistema do fornecedor.")]
        public async Task<IActionResult> InserirDocumento([FromBody] DocumentoModel documento)
        {
            var retorno = await documentoService.InserirDocumento(documento);
            
            return Ok($"{retorno.Mensagem} | {retorno.Informacao}");
        }
    }
}