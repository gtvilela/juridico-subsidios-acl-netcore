using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.EnvioFornecedor
{
    [Serializable()]
    [XmlRoot("InserirDocumento")]
    public class DocumentoFornecedorEnvioModel : FiltrosBase
    {
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
        /// Usuário que incluiu ou atualizou o documento
        /// </summary>
        public string Usuario { get; set; }
    }
}
