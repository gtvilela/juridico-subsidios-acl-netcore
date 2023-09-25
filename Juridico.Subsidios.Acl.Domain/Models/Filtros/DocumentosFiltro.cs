using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.Filtros
{

    [Serializable()]
    [XmlRoot("ConsultarDocumentosProcesso")]
    public class DocumentosFiltro : FiltrosBase
    {
        public string CodigoDocumento { get; set; }
        public string NomeDocumento { get; set; }

        public DocumentosFiltro(string processo)
        {
            CodigoProcesso = processo;
        }

        public DocumentosFiltro()
        {
        }
    }
}
