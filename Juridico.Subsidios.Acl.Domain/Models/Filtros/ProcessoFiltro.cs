using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.Filtros
{

    [Serializable()]
    [XmlRoot("ConsultarProcesso")]
    public class ProcessoFiltro : FiltrosBase
    {
        public string NumeroProcesso { get; set; }
        public string NumeroProcessoCliente { get; set; }

        public ProcessoFiltro(string processo)
        {
            CodigoProcesso = processo;
        }

        public ProcessoFiltro()
        {
        }
    }
}
