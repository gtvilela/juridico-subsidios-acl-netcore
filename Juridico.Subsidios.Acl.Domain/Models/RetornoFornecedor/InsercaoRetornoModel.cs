using Flunt.Notifications;
using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor
{
    [Serializable()]
    [XmlRoot(ElementName = "Root")]
    public class InsercaoRetornoModel : Notifiable<Notification>
    {
        public string Informacao { get; set; }
        public int CodigoStatus { get; set; }
        public string Status { get; set; }
        public string Mensagem { get; set; }
    }
}
