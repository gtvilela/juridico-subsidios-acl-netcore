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
        [Required(ErrorMessage = "Nome do documento é obrigatório.")]
        public string Nome { get; set; }
        /// <summary>
        /// Código do tipo de documento no fornecedor
        /// </summary>
        [SwaggerSchema(Description = "Código do tipo de documento no fornecedor. Em caso de dúvidas, verificar o código correto para o tipo de documento na feature flag configurada no ConfigCat.")]
        [Required(ErrorMessage = "Código do tipo do documento é obrigatório.")]
        public int CodigoTipo { get; set; }
        /// <summary>
        /// Nome do tipo do documento
        /// </summary>
        [SwaggerSchema(Description = "Nome do tipo de documento.")]
        public string Tipo { get; set; }
        /// <summary>
        /// Código do processo que deve ser inserido o documento no fornecedor.
        /// Para inserir ou atualizar um processo, essa informação não é obrigatória.
        /// Mas caso sejam utilizas as rotas de inclusão e atualização, essa informação é necessária.
        /// </summary>
        [SwaggerSchema(Description = "Código do processo que deve ser inserido o documento no fornecedor. Para inserir ou atualizar um processo, essa informação não é obrigatória, mas caso sejam utilizas as rotas de inclusão e atualização, essa informação é necessária.")]
        [Required(ErrorMessage = "Código do processo é obrigatório.")]
        public int CodigoProcesso { get; set; }
        /// <summary>
        /// Base64 referente ao documento
        /// </summary>
        [SwaggerSchema(Description = "Base64 referente ao documento")]
        [Required(ErrorMessage = "Arquivo no formato base64 é obrigatório.")]
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
