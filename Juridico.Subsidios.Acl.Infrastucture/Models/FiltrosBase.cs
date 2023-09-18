using Flunt.Notifications;

namespace Juridico.Meridio.Acl.Infrastructure.FiltrosModels
{
    public class FiltrosBase : Notifiable<Notification>
    {
        public string sUsuario { get; set; } = Environment.GetEnvironmentVariable("FORNECEDOR_SOAP_USER");
        public string sSenha { get; set; } = Environment.GetEnvironmentVariable("FORNECEDOR_SOAP_PWD");
        public string sCodigoProcesso { get; set; }
    }
}
