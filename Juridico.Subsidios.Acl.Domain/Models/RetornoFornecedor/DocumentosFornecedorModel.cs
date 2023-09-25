using Flunt.Notifications;

namespace Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor
{
    public class DocumentosFornecedorModel : Notifiable<Notification>
    {
        public List<DocumentoProcessoIntegracao> Documentos { get; set; }

    }

    public class DocumentoProcessoIntegracao
    {
        /// <summary>
        /// Código do processo no Fornecedor
        /// </summary>
        public string CodigoProcesso { get; set; }
        /// <summary>
        /// Número de controle do documento no Fornecedor
        /// </summary>
        public string NumeroDocumento { get; set; }
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
        /// Descrição detalhada do documento no Fornecedor
        /// </summary>
        public string DescricaoDetalhada { get; set; }
        /// <summary>
        /// Usuário que incluiu ou atualizou o documento
        /// </summary>
        public string Usuario { get; set; }
    }
}
