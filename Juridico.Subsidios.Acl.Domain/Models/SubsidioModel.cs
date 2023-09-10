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
        [Required(ErrorMessage = "Usuário responsável pelo processo não pode ser nulo.")]
        public string Usuario { get; set; }
        /// <summary>
        /// Código do processo no sistema do fornecedor
        /// </summary>
        [Required(ErrorMessage = "Código do processo não pode ser nulo.")]
        public string CodigoProcesso { get; set; }
        /// <summary>
        /// Identificação do veículo
        /// </summary>
        public string Placa { get; set; }
        /// <summary>
        /// Identificação da reverva feita pelo cliente
        /// </summary>
        public string Contrato { get; set; }
        /// <summary>
        /// Tipo de matéria legal do processo
        /// </summary>
        [Required(ErrorMessage = "MateriaLegal do processo não pode ser nulo.")]
        public string MateriaLegal { get; set; }
    }
}
