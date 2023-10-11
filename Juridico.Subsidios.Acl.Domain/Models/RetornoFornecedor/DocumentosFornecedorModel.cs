using Flunt.Notifications;
using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor
{
    [Serializable]
    [XmlRoot(ElementName = "Root")]
    public class DocumentosFornecedorModel : Notifiable<Notification>
    {
        public string CodigoProcesso { get; set; }

        [XmlArray("Documentos")]
        [XmlArrayItem("Element")]
        public List<DocumentoProcessoIntegracao> Documentos { get; set; }

    }
    [XmlType("Element")]
    public class DocumentoProcessoIntegracao
    {
        /// <summary>
        /// Número de controle do documento no Fornecedor
        /// </summary>
        public string NumeroDocumento { get; set; }
        /// <summary>
        /// Nome do documento no Fornecedor
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Descrição do documento no Fornecedor
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Arquivo no formato base64
        /// </summary>
        public string Arquivo { get; set; }
        /// <summary>
        /// Data de inclusão do documento no Fornecedor
        /// </summary>
        public string DataDocumento { get; set; }
        /// <summary>
        /// Código do tipo de documento no Fornecedor
        /// </summary>
        public string CodigoTipoDocumento { get; set; }
        /// <summary>
        /// Descrição do tipo de documento no Fornecedor
        /// </summary>
        public string DescricaoTipoDocumento { get; set; }
        /// <summary>
        /// Usuário que incluiu ou atualizou o documento
        /// </summary>
        public string Usuario { get; set; }
    }
}
