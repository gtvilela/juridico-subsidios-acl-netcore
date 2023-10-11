using ConfigCat.Client;
using Juridico.Subsidios.Acl.Domain.Interfaces;
using System.Text.Json;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public class ConfigCatService : IConfigCatService
    {
        private const string VALOR_DEFAULT = "[\"CTT\", \"CNH\", \"CRLV\", \"CPPAG\"]";
        private readonly string CONFIGCAT_KEY = Environment.GetEnvironmentVariable("CHAVE_CONFIGCAT");
        private readonly string CODIGOS_INFO_ADICIONAIS = "codigosinformacoesadicionais";


        private IConfigCatClient GetClient()
        {
            return ConfigCatClient.Get(CONFIGCAT_KEY);
        }

        public string BuscarSiglasDocumento(string materiaLegal)
        {
            var client = GetClient();

            switch (materiaLegal)
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
            client.Dispose();
        }

        public string BuscarCodigoInformacaoAdicional(string infoAdd)
        {
            var client = GetClient();
            var codigosInformacoesAdicionais = client.GetValue(CODIGOS_INFO_ADICIONAIS, VALOR_DEFAULT);
            var codigosTratados = JsonDocument.Parse(codigosInformacoesAdicionais);
            var retornoInfoAdd = codigosTratados.RootElement.GetProperty(infoAdd).ToString();
            client.Dispose();
            return retornoInfoAdd;
        }
    }
}
