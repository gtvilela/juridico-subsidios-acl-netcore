using Flunt.Notifications;

namespace Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor
{
    public class InformacaoAdicionalFornecedorModel : Notifiable<Notification>
    {
        public List<InformacaoAdicionalProcessoIntegracao> InformacoesAdicionais { get; set; }

    }

    public class InformacaoAdicionalProcessoIntegracao
    {
        /// <summary>
        /// Código de controle do Fornecedor para a informação adicional
        /// </summary>
        public string CodigoInforAdicionalProcesso { get; set; }
        /// <summary>
        /// Código utilizado pela localiza para identificar o tipo de informação adicional no Fornecedor
        /// </summary>
        public string CodigoTipoInfoAddProcesso { get; set; }
        /// <summary>
        /// Descrição/Nome da informação adicional no Fornecedor
        /// </summary>
        public string DescricaoTipoInfoAddProcesso { get; set; }
        /// <summary>
        /// Código do processo no Fornecedor
        /// </summary>
        public string CodigoProcesso { get; set; }
        /// <summary>
        /// Valor da informação adicional no Fornecedor
        /// </summary>
        public string InformacaoAdicional { get; set; }
        /// <summary>
        /// Observações da informação adicional
        /// </summary>
        public string Observacoes { get; set; }
        /// <summary>
        /// Tipo da informação. Pode ser Pública ou Confidencial.
        /// </summary>
        public string TipoInformacao { get; set; }
        /// <summary>
        /// Usuário cadastrado no Fornecedor que realizou a última alteração
        /// </summary>
        public string Usuario { get; set; }
    }
}
