using ConfigCat.Client;
using Juridico.Subsidios.Acl.Domain.Interfaces;
using System.Text;
using System.Text.Json;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public class ConfigCatService : IConfigCatService
    {
        #region Valores Constantes
        private const string VALOR_DEFAULT = "['CTT', 'CNH', 'CRLV', 'CPPAG']";
        private readonly string CODIGOS_INFO_ADICIONAIS = "codigosinformacoesadicionais";
        private readonly string CODIGOS_DOCUMENTOS = "codigosdocumentos";
        private const string VALOR_DEFAULT_INFORMACOES_ADICIONAIS = @"{
                                                                        ""contrato"": 1,
                                                                        ""placa"": 2,
                                                                        ""condutorAdicional"": 3,
                                                                        ""codigoCliente"":  4,
                                                                        ""dataAberturaContrato"": 5,
                                                                        ""dataFechamentoContrato"": 6,
                                                                        ""codigoSinistro"": 7,
                                                                        ""modeloVeiculo"": 8,
                                                                        ""anoModelo"": 9
                                                                      }";

        private const string VALOR_DEFAULT_DOCUMENTOS = @"{
                                                                        ""crlv"": 1,
                                                                        ""bo"": 2,
                                                                        ""cnh"": 3,
                                                                        ""contrato"": 4,
                                                                        ""comprovantePagamento"": 5
                                                                    }";
        #endregion

        private static IConfigCatClient GetClient()
        {
            return ConfigCatClient.Get("SrLbCIovz0WBRTdD1B3V4A/LmfQyYcRtUWPywYfDG5uvQ");
        }

        public string BuscarSiglasDocumento(string materiaLegal)
        {
            var client = GetClient();

            return materiaLegal switch
            {
                "civel" => client.GetValue("documentosCivel", VALOR_DEFAULT),
                "criminal" => client.GetValue("documentosCriminal", VALOR_DEFAULT),
                "trabalhista" => client.GetValue("documentosTrabalhista", VALOR_DEFAULT),
                "tributario" => client.GetValue("documentosTributario", VALOR_DEFAULT),
                _ => string.Empty,
            };
        }

        public async Task<JsonDocument> BuscarCodigosInformacoesAdicionais()
        {
            return await RetornarCodigosSubsidios(CODIGOS_INFO_ADICIONAIS, VALOR_DEFAULT_INFORMACOES_ADICIONAIS);
        }
        public async Task<JsonDocument> BuscarCodigosDocumentos()
        {
            return await RetornarCodigosSubsidios(CODIGOS_DOCUMENTOS, VALOR_DEFAULT_DOCUMENTOS);
        }

        private async Task<JsonDocument> RetornarCodigosSubsidios(string idConfigCat, string valorDefault)
        {
            var client = GetClient();
            var codigosInformacoesAdicionais = client.GetValue(idConfigCat, valorDefault);
            var content = new StringContent(codigosInformacoesAdicionais, Encoding.UTF8, "application/json");
            return JsonDocument.Parse(await content.ReadAsStringAsync());
        }

    }
}
