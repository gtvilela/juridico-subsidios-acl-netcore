using Flunt.Notifications;
using Juridico.Subsidios.Acl.Domain.Models.Filtros;

namespace Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor
{
    public class ProcessoFornecedorModel : Notifiable<Notification>
    {
        /// <summary>
        /// Código do processo
        /// </summary>
        public string Codigo { get; set; }
        /// <summary>
        /// Centro de custo no fornecedor
        /// </summary>
        public string NumeroCentroCusto { get; set; }
        /// <summary>
        /// Codigo da fase do processo
        /// </summary>
        public string CodigoFaseProcesso { get; set; }
        /// <summary>
        /// Materia legal do fornecedor
        /// </summary>
        public string Materialegal { get; set; }
        /// <summary>
        /// Codigo advogado
        /// </summary>
        public string CodigoAdvogadoAutor { get; set; }
        /// <summary>
        /// Nome do réu
        /// </summary>
        public string NomeReu { get; set; }
        /// <summary>
        /// Numero Processo
        /// </summary>
        public string NumeroProcesso { get; set; }
        /// <summary>
        /// Data da distribuicao
        /// </summary>
        public string DataDistribuicao { get; set; }
        /// <summary>
        /// Data do recebimento
        /// </summary>
        public string DataRecebimento { get; set; }
        /// <summary>
        /// Sigla UF
        /// </summary>
        public string SiglaUf { get; set; }
        /// <summary>
        ///  vara associada ao processo
        /// </summary>
        public string Vara { get; set; }
        /// <summary>
        /// Tribunal do processo
        /// </summary>
        public string ValorEnvolvido { get; set; }
        /// <summary>
        /// Multa do processo ex:9000.50 valor depois do ponto são centavos
        /// </summary>
        public string Multa { get; set; }
        /// <summary>
        /// Juros do processo ex:9000.50 valor depois do ponto são centavos
        /// </summary>
        public string Juros { get; set; }
        /// <summary>
        /// Número do processo eletrônico
        /// </summary>
        public string ProcessoEletronico { get; set; }
        /// <summary>
        /// Usuário responsável pelo processo
        /// </summary>
        public string Usuario { get; set; }
    }
}
