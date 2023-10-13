using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.EnvioFornecedor
{
    [Serializable()]
    [XmlRoot("InserirInformacaoAdicional")]
    public class InformacaoAdicionalFornecedorEnvioModel : FiltrosBase
    {
        /// <summary>
        /// Código de controle do Fornecedor para a informação adicional
        /// </summary>
        public string CodigoTipo { get; set; }
        /// <summary>
        /// Descrição/Nome da informação adicional no Fornecedor
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Valor da informação adicional no Fornecedor
        /// </summary>
        public string Valor { get; set; }
        /// <summary>
        /// Observações da informação adicional
        /// </summary>
        public string Observacoes { get; set; }
        /// <summary>
        /// Usuário cadastrado no Fornecedor que realizou a última alteração
        /// </summary>
        public string Usuario { get; set; }
    }
}
