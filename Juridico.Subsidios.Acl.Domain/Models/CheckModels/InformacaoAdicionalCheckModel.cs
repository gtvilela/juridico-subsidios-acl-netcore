using Juridico.Subsidios.Acl.Domain.Extensions;
using Juridico.Subsidios.Acl.Domain.Interfaces.Services;
using System.Text.Json;

namespace Juridico.Subsidios.Acl.Domain.Models.CheckModels
{
    public class InformacaoAdicionalCheckModel
    {
        /// <summary>
        /// Referência do contrato da placa no fornecedor
        /// </summary>
        public bool Contrato { get; set; }
        /// <summary>
        /// Referência do campo da placa no fornecedor
        /// </summary>
        public bool Placa { get; set; }
        /// <summary>
        /// Referência do campo da Condutor Adicional no fornecedor
        /// </summary>
        public bool CondutorAdicional { get; set; }
        /// <summary>
        /// Referência do campo do Código do Cliente no fornecedor
        /// </summary>
        public bool CodigoCliente { get; set; }
        /// <summary>
        /// Referência do campo do Código do Sinistro no fornecedor
        /// </summary>
        public bool CodigoSinistro { get; set; }
        /// <summary>
        /// Referência do campo Data Abertura no fornecedor
        /// </summary>
        public bool DataAbertura { get; set; }
        /// <summary>
        /// Referência do campo Data Fechamento no fornecedor
        /// </summary>
        public bool DataFechamento { get; set; }
        /// <summary>
        /// Referência do campo Ano Modelo Veículo no fornecedor
        /// </summary>
        public bool AnoModelo { get; set; }
        /// <summary>
        /// Referência do campo Modelo Veículo no fornecedor
        /// </summary>
        public bool ModeloVeiculo { get; set; }

        public InformacaoAdicionalCheckModel(List<InformacaoAdicionalModel> informacoesAdicionais,
                                    IConfigCatService configCatService)
        {
            var codigosInformacoesAdicionais = configCatService.BuscarCodigosInformacoesAdicionais().Result;
            Placa = InformacaoAdicionalJaCadastrada(nameof(Placa), codigosInformacoesAdicionais, informacoesAdicionais);
            CodigoCliente = InformacaoAdicionalJaCadastrada(nameof(CodigoCliente), codigosInformacoesAdicionais, informacoesAdicionais);
            CodigoSinistro = InformacaoAdicionalJaCadastrada(nameof(CodigoSinistro), codigosInformacoesAdicionais, informacoesAdicionais);
            Contrato = InformacaoAdicionalJaCadastrada(nameof(Contrato), codigosInformacoesAdicionais, informacoesAdicionais);
            DataAbertura = InformacaoAdicionalJaCadastrada(nameof(DataAbertura), codigosInformacoesAdicionais, informacoesAdicionais);
            DataFechamento = InformacaoAdicionalJaCadastrada(nameof(DataFechamento), codigosInformacoesAdicionais, informacoesAdicionais);
            ModeloVeiculo = InformacaoAdicionalJaCadastrada(nameof(ModeloVeiculo), codigosInformacoesAdicionais, informacoesAdicionais);
            AnoModelo = InformacaoAdicionalJaCadastrada(nameof(AnoModelo), codigosInformacoesAdicionais, informacoesAdicionais);
            CondutorAdicional = InformacaoAdicionalJaCadastrada(nameof(CondutorAdicional), codigosInformacoesAdicionais, informacoesAdicionais);
        }

        private static bool InformacaoAdicionalJaCadastrada(string infoAdd, 
                                                            JsonDocument jsonInfoAdds, 
                                                            List<InformacaoAdicionalModel> informacoesAdicionais)
        {
            var codigoInformacaoAdicional = jsonInfoAdds.RootElement.GetProperty(infoAdd.ToCamelCase()).ToString();
            return informacoesAdicionais.Any(x => x.CodigoTipo == Convert.ToInt32(codigoInformacaoAdicional));
        }
    }
}