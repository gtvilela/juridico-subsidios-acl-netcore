using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Juridico.Subsidios.Acl.Domain.Models
{
    /// <summary>
    /// Objeto recebido pela trigger do sistema terceiro
    /// </summary>
    public class InformacaoAdicionalModel
    {
        /// <summary>
        /// Código da informação adicional cadastrada no fornecedor
        /// </summary>
        [SwaggerSchema(Description = "Código da informação adicional cadastrada no fornecedor.")]
        public int Codigo { get; set; }
        /// <summary>
        /// Valor da informação adicional
        /// </summary>
        [SwaggerSchema(Description = "Valor da informação adicional.")]
        public string Valor { get; set; }
        /// <summary>
        /// Identificação do veículo
        /// </summary>
        [SwaggerSchema(Description = "Identificação do veículo.")]
        public string Descricao { get; set; }

    }
}
