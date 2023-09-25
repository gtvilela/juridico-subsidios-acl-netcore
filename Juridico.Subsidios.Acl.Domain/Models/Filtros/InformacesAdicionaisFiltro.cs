using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.Filtros
{

    [Serializable()]
    [XmlRoot("ConsultarInformacaoAdicionalProcesso")]
    public class InformacesAdicionaisFiltro : FiltrosBase
    {
        public string CodigoInformacaoAdicional { get; set; }

        public InformacesAdicionaisFiltro(string processo)
        {
            CodigoProcesso = processo;
        }
    }
}
