using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.Filtros
{

    [Serializable()]
    [XmlRoot("ConsultarProcesso")]
    public class ConsultarProcessoFiltros : FiltrosBase
    {
        public string sNumeroProcesso { get; set; }
        public string sNumeroProcessoCliente { get; set; }
    }
}
