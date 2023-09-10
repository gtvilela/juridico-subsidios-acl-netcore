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
        [SwaggerSchema(Description = "Código da informação adicional cadastrada no fornecedor")]
        public string Código { get; set; }
        /// <summary>
        /// Tipo da informação adicional
        /// </summary>
        [SwaggerSchema(Description = "Tipo da informação adicional")]
        public string Tipo { get; set; }
        /// <summary>
        /// Identificação do veículo
        /// </summary>
        [SwaggerSchema(Description = "Identificação do veículo")]
        public string Descrição { get; set; }

    }
}
