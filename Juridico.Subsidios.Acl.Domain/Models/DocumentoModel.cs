using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Juridico.Subsidios.Acl.Domain.Models
{
    /// <summary>
    /// Objeto recebido pela trigger do sistema terceiro
    /// </summary>
    public class DocumentoModel
    {
        /// <summary>
        /// Nome do documento com extensão
        /// </summary>
        [SwaggerSchema(Description = "Nome do documento com extensão")]
        public string Nome { get; set; }
        /// <summary>
        /// Código do tipo de documento no fornecedor
        /// </summary>
        [SwaggerSchema(Description = "Código do tipo de documento no fornecedor")]
        public int CodigoTipoDocumento { get; set; }
        /// <summary>
        /// Nome do tipo do documento
        /// </summary>
        [SwaggerSchema(Description = "Nome do tipo de documento.")]
        public string TipoDocumento { get; set; }
        /// <summary>
        /// Código do processo que deve ser inserido o documento no fornecedor.
        /// Para inserir ou atualizar um processo, essa informação não é obrigatória.
        /// Mas caso sejam utilizas as rotas de inclusão e atualização, essa informação é necessária.
        /// </summary>
        [SwaggerSchema(Description = "Código do processo que deve ser inserido o documento no fornecedor. Para inserir ou atualizar um processo, essa informação não é obrigatória, mas caso sejam utilizas as rotas de inclusão e atualização, essa informação é necessária.")]
        public string CodigoProcesso { get; set; }
        /// <summary>
        /// Base64 referente ao documento
        /// </summary>
        [SwaggerSchema(Description = "Base64 referente ao documento")]
        public string Base64 { get; set; }
        /// <summary>
        /// Descrição do documento
        /// </summary>
        [SwaggerSchema(Description = "Descrição do documento")]
        public string Descricao { get; set; }
        /// <summary>
        /// Data de inclusão do documento no sistema do fornecedor
        /// </summary>
        [SwaggerSchema(Description = "Data de inclusão do documento no sistema do fornecedor")]
        public DateTime DataInclusao { get; set; }
        /// <summary>
        /// Usuário responsável pela inclusão do documento
        /// </summary>
        [SwaggerSchema(Description = "Usuário responsável pela inclusão do documento")]
        public string Usuario { get; set; }
    }
}
