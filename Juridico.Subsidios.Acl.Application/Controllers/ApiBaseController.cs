using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Diagnostics.CodeAnalysis;

namespace Juridico.Nucleo.Subsidios.Application.Controllers
{
    [ExcludeFromCodeCoverage]
    public abstract class ApiBaseController<T> : ControllerBase
    {
        private readonly ILogger<T> _logger;

        public ApiBaseController(ILogger<T> logger)
        {
            _logger = logger;
        }
        protected BadRequestObjectResult BadRequest(string message)
        {
            _logger.Log(LogLevel.Error, message);
            return new BadRequestObjectResult(message);
        }

        protected NotFoundObjectResult NotFound(string message)
        {
            _logger.Log(LogLevel.Error, message);
            return new NotFoundObjectResult(message);
        }

        protected IActionResult InternalServerError()
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, "Ocorreu um erro interno. Não foi possivel comunicar com o servidor.");
        }

        protected IActionResult InternalServerError(string message)
        {
            _logger.Log(LogLevel.Error, message);
            return StatusCode((int)HttpStatusCode.InternalServerError, message);
        }
    }
}