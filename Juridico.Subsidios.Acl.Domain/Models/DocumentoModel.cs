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
