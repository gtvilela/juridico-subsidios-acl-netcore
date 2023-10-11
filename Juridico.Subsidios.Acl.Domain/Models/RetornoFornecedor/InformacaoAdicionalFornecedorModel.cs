using Flunt.Notifications;
using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor
{
    [Serializable]
    [XmlRoot(ElementName = "Root")]
    public class InformacaoAdicionalFornecedorModel : Notifiable<Notification>
    {
        public string CodigoProcesso { get; set; }

        [XmlArray("InformacoesAdicionais")]
        [XmlArrayItem("Element")]
        public List<InformacaoAdicionalProcessoIntegracao> InformacoesAdicionais { get; set; }

    }
    [XmlType("Element")]
    public class InformacaoAdicionalProcessoIntegracao
    {
        /// <summary>
        /// Código de controle do Fornecedor para a informação adicional
        /// </summary>
        public string Codigo { get; set; }
        /// <summary>
        /// Descrição/Nome da informação adicional no Fornecedor
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Valor da informação adicional no Fornecedor
        /// </summary>
        public string InformacaoAdicional { get; set; }
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
