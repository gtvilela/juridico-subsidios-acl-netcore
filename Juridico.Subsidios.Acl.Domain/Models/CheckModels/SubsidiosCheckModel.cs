using Juridico.Subsidios.Acl.Domain.Interfaces.Services;

namespace Juridico.Subsidios.Acl.Domain.Models.CheckModels
{
    /// <summary>
    /// Objeto recebido pela trigger do sistema terceiro
    /// </summary>
    public class SubsidiosCheckModel
    {
        public InformacaoAdicionalCheckModel InfosmacoesAdicionaisCheck { get; set; }
        public DocumentosCheckModel DocumentosCheck { get; set; }

        public SubsidiosCheckModel(IConfigCatService configCatService, ProcessoModel processo)
        {
            InfosmacoesAdicionaisCheck = new InformacaoAdicionalCheckModel(processo.InformacoesAdicionais, configCatService);
            DocumentosCheck = new DocumentosCheckModel(processo.Documentos, configCatService);
        }
    }
}
