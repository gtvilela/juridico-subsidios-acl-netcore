using System.Text.Json;

namespace Juridico.Subsidios.Acl.Domain.Interfaces.Services
{
    public interface IConfigCatService
    {
        Task<JsonDocument> BuscarCodigosInformacoesAdicionais();
        Task<JsonDocument> BuscarCodigosDocumentos();
        string BuscarSiglasDocumento(string materiaLegal);
    }
}