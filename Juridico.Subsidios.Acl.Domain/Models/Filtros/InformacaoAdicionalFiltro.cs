using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.Filtros
{

    [Serializable()]
    [XmlRoot("ConsultarInformacaoAdicionalProcesso")]
    public class InformacaoAdicionalFiltro : FiltrosBase
    {
        public string CodigoInformacaoAdicional { get; set; }
    }
}
