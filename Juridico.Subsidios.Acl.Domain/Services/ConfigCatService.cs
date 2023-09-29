using ConfigCat.Client;

namespace Juridico.Subsidios.Acl.Domain.Services
{
    public class ConfigCatService
    {
        private const string VALOR_DEFAULT = "[\"CTT\", \"CNH\", \"CRLV\", \"CPPAG\"]";
        private readonly string CONFIGCAT_KEY = Environment.GetEnvironmentVariable("CHAVE_CONFIGCAT");
        private IConfigCatClient Get()
        {
            return ConfigCatClient.Get(CONFIGCAT_KEY);
        }

        public string BuscarSiglasDocumento(string materiaLegal)
        {
            var client = Get();

            switch(materiaLegal)
            {
                case "civel":
                    return client.GetValue("documentosCivel", VALOR_DEFAULT);
                case "criminal":
                    return client.GetValue("documentosCriminal", VALOR_DEFAULT);
                case "trabalhista":
                    return client.GetValue("documentosTrabalhista", VALOR_DEFAULT);
                case "tributario":
                    return client.GetValue("documentosTributario", VALOR_DEFAULT);
                default:
                    return string.Empty;
            }
        }
    }
}
