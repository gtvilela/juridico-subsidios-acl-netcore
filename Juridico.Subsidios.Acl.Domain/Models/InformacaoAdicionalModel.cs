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
        [SwaggerSchema(Description = "Código da informação adicional cadastrada no fornecedor. Em caso de dúvidas, verificar o código correto para a informação adicional na feature flag configurada no ConfigCat.")]
        [Required(ErrorMessage = "Código do tipo da informação adicional é obrigatório.")]
        public int CodigoTipo { get; set; }
        /// <summary>
        /// Código do processo que deve ser inserida a informação adicional no fornecedor.
        /// Para inserir ou atualizar um processo, essa informação não é obrigatória.
        /// Mas caso sejam utilizas as rotas de inclusão e atualização, essa informação é necessária.
        /// </summary>
        [SwaggerSchema(Description = "Código do processo que deve ser inserida a informação adicional no fornecedor. Para inserir ou atualizar um processo, essa informação não é obrigatória, mas caso sejam utilizas as rotas de inclusão e atualização, essa informação é necessária.")]
        [Required(ErrorMessage = "Código do processo é obrigatório.")]
        public int CodigoProcesso { get; set; }
        /// <summary>
        /// Nome da informação adicional cadastrada no fornecedor
        /// </summary>
        [SwaggerSchema(Description = "Nome da informação adicional cadastrada no fornecedor.")]
        public string Nome { get; set; }
        /// <summary>
        /// Valor da informação adicional
        /// </summary>
        [SwaggerSchema(Description = "Valor da informação adicional.")]
        [Required(ErrorMessage = "Valor da informação adicional é obrigatório.")]
        public string Valor { get; set; }
        /// <summary>
        /// Identificação do veículo
        /// </summary>
        [SwaggerSchema(Description = "Identificação do veículo.")]
        public string Descricao { get; set; }
        /// <summary>
        /// Código do usuário que inseriu ou editou a informação adicional
        /// </summary>
        [SwaggerSchema(Description = "Código do usuário que inseriu ou editou a informação adicional")]
        public string Usuario { get; set; }

    }
}
