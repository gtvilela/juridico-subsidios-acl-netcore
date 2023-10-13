using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Juridico.Subsidios.Acl.Domain.Models
{
    /// <summary>
    ///Modelo de dados para cadastro e  obtenção de andamento no processo.
    /// </summary>
    public class AndamentoModel
    {
        /// <summary>
        /// Código do tipo de andamento do processo no fornecedor.
        /// </summary>
        [SwaggerSchema(Description = "Código do tipo de andamento do processo no fornecedor. Sempre será do tipo Processamento de Subsídios, o código está configurado na feature flag no ConfigCat.")]
        [Required(ErrorMessage = "Código do tipo de andamento do processo é obrigatório.")]
        public int CodigoTipo { get; set; }
        /// <summary>
        /// Tipo de andamento do processo no fornecedor.
        /// </summary>
        [SwaggerSchema(Description = "Tipo de andamento do processo no fornecedor.")]
        public string Tipo { get; set; }
        /// <summary>
        /// Código do processo que deve ser inserido o andamento no fornecedor.
        /// </summary>
        [SwaggerSchema(Description = "Código do processo que deve ser inserido o andamento no fornecedor.")]
        [Required(ErrorMessage = "Código do processo é obrigatório.")]
        public int CodigoProcesso { get; set; }
        /// <summary>
        /// Campo de descrição onde será cadastrado o log de busca automatizada de subsídios.
        /// </summary>
        [SwaggerSchema(Description = "Campo de descrição onde será cadastrado o log de busca automatizada de subsídios.")]
        [Required(ErrorMessage = "Descrição do andamento é obrigatório.")]
        public string Descricao { get; set; }
        /// <summary>
        /// Data de início do andamento.
        /// </summary>
        [SwaggerSchema(Description = "Data de início do andamento.")]
        public DateTime DataInicio { get; set; }
        /// <summary>
        /// Data de conclusão do andamento.
        /// </summary>
        [SwaggerSchema(Description = "Data de conclusão do andamento.")]
        public string DataConclusao { get; set; }
        /// <summary>
        /// Prazo em dias para o andamento ser realizado pelo usuário atribído.
        /// </summary>
        [SwaggerSchema(Description = "Prazo em dias para o andamento ser realizado pelo usuário atribído.")]
        public int Prazo { get; set; }
        /// <summary>
        /// Usuário responsável pela inclusão do andamento
        /// </summary>
        [SwaggerSchema(Description = "Usuário responsável pela inclusão do andamento.")]
        public string Usuario { get; set; }
    }
}
