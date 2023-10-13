using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Models.EnvioFornecedor
{
    [Serializable()]
    [XmlRoot("InserirAndamento")]
    public class AndamentoFornecedorEnvioModel : FiltrosBase
    {
        /// <summary>
        /// Código do tipo de andamento no Fornecedor
        /// </summary>
        public string CodigoTipo { get; set; }
        /// <summary>
        /// Descrição do andamento no Fornecedor
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Usuário que incluiu ou atualizou o andamento
        /// </summary>
        public string Usuario { get; set; }
    }
}
