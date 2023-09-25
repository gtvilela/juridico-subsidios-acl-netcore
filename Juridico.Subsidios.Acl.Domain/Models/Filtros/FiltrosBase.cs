using Flunt.Notifications;

namespace Juridico.Subsidios.Acl.Domain.Models.Filtros
{
    public class FiltrosBase : Notifiable<Notification>
    {
        public string Usuario { get; set; } = Environment.GetEnvironmentVariable("FORNECEDOR_SOAP_USER");
        public string Senha { get; set; } = Environment.GetEnvironmentVariable("FORNECEDOR_SOAP_PWD");
        public string CodigoProcesso { get; set; }
    }
}
