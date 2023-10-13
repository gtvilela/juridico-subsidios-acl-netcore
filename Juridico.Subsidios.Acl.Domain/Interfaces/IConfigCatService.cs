using System.Text.Json;

namespace Juridico.Subsidios.Acl.Domain.Interfaces
{
    public interface IConfigCatService
    {
        Task<JsonDocument> BuscarCodigosInformacoesAdicionais();
        Task<JsonDocument> BuscarCodigosDocumentos();
        string BuscarSiglasDocumento(string materiaLegal);
    }
}