using Flunt.Notifications;
using Juridico.Meridio.Acl.Infrastructure.FiltrosModels;

namespace Juridico.Subsidios.Acl.Infrastucture.Models
{
    public class ProcessoFornecedorModel : FiltrosBase
    {
        public ProcessoFornecedorModel() 
        {
            if (string.IsNullOrWhiteSpace(sCodigoProcesso))
                AddNotification(nameof(sCodigoProcesso), "Código do processo não pode ser nulo");

            if (string.IsNullOrWhiteSpace(NSUDistribuicao))
                AddNotification(nameof(NSUDistribuicao), "NSUDistribuicao não pode ser nulo");

            if (string.IsNullOrWhiteSpace(NumeroProcesso))
                AddNotification(nameof(NumeroProcesso), "Numero Processo não pode ser nulo");

            if (string.IsNullOrWhiteSpace(Tribunal))
                AddNotification(nameof(Tribunal), "Tribunal não pode ser nulo");

            if (string.IsNullOrWhiteSpace(CodigoMaterialegal))
                AddNotification(nameof(CodigoMaterialegal), "Codigo Materia legal não pode ser nulo");
        }
       
        /// <summary>
        /// Numero NSU Distribuicao para alterar como executado após inclusão
        /// </summary>
        public string NSUDistribuicao { get; set; }
        /// <summary>
        /// Codigo da empresa no fornecedor
        /// </summary>
        public string CodigoEmpresa { get; set; }
        /// <summary>
        /// Termo de pesquisa, utilizado caso o CodigoEmpresa não seja preenchido
        /// </summary>
        public string TermoPesquisado { get; set; }
        /// <summary>
        /// Centro de custo no fornecedor
        /// </summary>
        public string NumeroCentroCusto { get; set; }
        /// <summary>
        /// Codigo da fase do processo
        /// </summary>
        public string CodigoFaseProcesso { get; set; }
        /// <summary>
        /// Empresa Autor ou Reu
        /// </summary>
        public string ParteEmpresa { get; set; }
        /// <summary>
        /// Codigo natureza fornecedor
        /// </summary>
        public string CodigoNaturezaAcao { get; set; }
        /// <summary>
        /// Codigo materia legal do fornecedor
        /// </summary>
        public string CodigoMaterialegal { get; set; }
        /// <summary>
        /// Codigo profissional do processo
        /// </summary>
        public string ProfissionalProcesso { get; set; }
        /// <summary>
        /// Codigo do profissional
        /// </summary>
        public string ProfissionalAudiencia { get; set; }
        /// <summary>
        /// Codigo advogado
        /// </summary>
        public string CodigoAdvogadoAutor { get; set; }
        /// <summary>
        /// Lista nome dos autores
        /// </summary>
        public string ListaNomeAutor { get; set; }
        /// <summary>
        /// Lista dos codigos dos principais autores
        /// </summary>
        public string ListaPrincipalAutor { get; set; }
        /// <summary>
        /// Lista dos nomes do Réus
        /// </summary>
        public string ListaNomeReu { get; set; }
        /// <summary>
        /// Lista dos codigos dos principais Réus
        /// </summary>
        public string ListaPrincipalReu { get; set; }
        /// <summary>
        /// Codigo do procedimento
        /// </summary>
        public string CodigoProcedimento { get; set; }
        /// <summary>
        /// Codigo tipo recurso
        /// </summary>
        public string CodigoTipoRecurso { get; set; }
        /// <summary>
        /// Codigo processo principal
        /// </summary>
        public string CodigoProcessoPrincipal { get; set; }
        /// <summary>
        /// Codigo caso principal
        /// </summary>
        public string CodigoCasoPrincipal { get; set; }
        /// <summary>
        /// Codigo processo associado
        /// </summary>
        public string CodigoProcessoAssociado { get; set; }
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
        /// Codigo do Município
        /// </summary>
        public string CodigoMunicipio { get; set; }
        /// <summary>
        /// Descricao do Município
        /// </summary>
        public string DescricaoMunicipio { get; set; }
        /// <summary>
        /// Sigla UF
        /// </summary>
        public string SiglaUF { get; set; }
        /// <summary>
        /// Codigo do Forum
        /// </summary>
        public string CodigoForum { get; set; }
        /// <summary>
        /// Descricao do Forum
        /// </summary>
        public string DescricaoForum { get; set; }
        /// <summary>
        /// Codigo da Vara
        /// </summary>
        public string CodigoVara { get; set; }
        /// <summary>
        /// Descricao da vara
        /// </summary>
        public string DescricaoVara { get; set; }
        /// <summary>
        /// Tribunal do processo
        /// </summary>
        public string Tribunal { get; set; }
        /// <summary>
        /// Data da audiencia do processo
        /// </summary>
        public string DataAudiencia { get; set; }
        /// <summary>
        /// Valor envolvido do processo
        /// </summary>
        public string ValorEnvolvido { get; set; }
        /// <summary>
        /// Tipo da ocorrencia do processo
        /// </summary>
        public string TipoOcorrencia { get; set; }
        /// <summary>
        /// Fato inicial do processo
        /// </summary>
        public string FatoInicial { get; set; }
        /// <summary>
        /// Valor do processo ex:9000.50 valor depois do ponto são centavos
        /// </summary>
        public string Valor { get; set; }
        /// <summary>
        /// Multa do processo ex:9000.50 valor depois do ponto são centavos
        /// </summary>
        public string Multa { get; set; }
        /// <summary>
        /// Juros do processo ex:9000.50 valor depois do ponto são centavos
        /// </summary>
        public string Juros { get; set; }
    }
}
