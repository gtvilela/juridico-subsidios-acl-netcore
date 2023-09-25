using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Juridico.Subsidios.Acl.Domain.Models
{
    /// <summary>
    /// Objeto recebido pela trigger do sistema terceiro
    /// </summary>
    public class SubsidioModel
    {
        /// <summary>
        /// Usuário associado ao processo
        /// </summary>
        [SwaggerSchema(Description = "Usuário responsável pelo processo")]
        [Required(ErrorMessage = "Usuário responsável pelo processo não pode ser nulo.")]
        public string Usuario { get; set; }
        /// <summary>
        /// Código do processo no sistema do fornecedor
        /// </summary>
        [SwaggerSchema(Description = "Código do processo no sistema do fornecedor.")]
        [Required(ErrorMessage = "Código do processo não pode ser nulo.")]
        public string CodigoProcesso { get; set; }
        /// <summary>
        /// Identificação do veículo
        /// </summary>
        [SwaggerSchema(Description = "Identificação do veículo")]
        public string Placa { get; set; }
        /// <summary>
        /// Identificação da reverva feita pelo cliente
        /// </summary>
        [SwaggerSchema(Description = "Identificação da reverva feita pelo cliente")]
        public string Contrato { get; set; }
        /// <summary>
        /// Tipo de matéria legal do processo. 
        /// </summary>
        [SwaggerSchema(Description = "Tipo de matéria legal do processo. Cível, Criminal, Trabalhista ou Tributário.")]
        [Required(ErrorMessage = "MateriaLegal do processo não pode ser nulo.")]
        public string MateriaLegal { get; set; }
    }
}
