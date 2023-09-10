using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Juridico.Subsidios.Acl.Domain.Models
{
    /// <summary>
    /// Objeto recebido pela trigger do sistema terceiro
    /// </summary>
    public class ProcessoModel
    {
        /// <summary>
        /// Código do processo no sistema do fornecedor
        /// </summary>
        [SwaggerSchema(Description = "Código do processo no sistema do fornecedor")]
        public string Codigo { get; set; }
        /// <summary>
        /// Usuário responsável pelo processo
        /// </summary> 
        [SwaggerSchema(Description = "Usuário responsável pelo processo")]
        [Required(ErrorMessage = "Usuário responsável pelo processo não pode ser nulo.")]
        public string Usuario { get; set; }
        /// <summary>
        /// Número do processo no Tribunal de Justiça
        /// </summary>
        [SwaggerSchema(Description = "Número do processo no Tribunal de Justiça")]
        [Required(ErrorMessage = "Número do processo não pode ser nulo.")]
        public string NumeroProcesso { get; set; }
        /// <summary>
        /// Vara associada ao Processo
        /// </summary>
        [SwaggerSchema(Description = "Vara associada ao Processo")]
        public string Vara { get; set; }
        /// <summary>
        /// Matéria Legal associada ao processo
        /// </summary>
        [SwaggerSchema(Description = "Matéria Legal associada ao processo")]
        [Required(ErrorMessage = "Matéria legal não pode ser nula.")]
        public string MateriaLegal { get; set; }
        /// <summary>
        /// Comarca associada ao processo
        /// </summary>
        [SwaggerSchema(Description = "Comarca associada ao processo")]
        public string Comarca { get; set; }
        /// <summary>
        /// Estado do processo
        /// </summary>
        [SwaggerSchema(Description = "Sigla da UF associada ao processo")]
        public string Estado { get; set; }
        /// <summary>
        /// Número do E-processo
        /// </summary>
        [SwaggerSchema(Description = "Número do E-processo")]
        public string ProcessoEletronico { get; set; }

        /// <summary>
        /// Lista de subsídios do tipo Informações Adicionais
        /// </summary>
        [SwaggerSchema(Description = "Lista de subsídios do tipo Informações Adicionais")]
        public List<InformacaoAdicionalModel> InformacoesAdicionais { get; set; }
        /// <summary>
        /// Lista de subsídios do tipo Documentos
        /// </summary>
        [SwaggerSchema(Description = "Lista de subsídios do tipo Documentos")]
        public List<DocumentoModel> Documentos { get; set; }
    }
}
