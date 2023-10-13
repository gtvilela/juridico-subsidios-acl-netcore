using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Infrastucture.Services;

namespace Juridico.Subsidios.Acl.Infrastucture.Handlers
{
    public class ProcessoHandler : IProcessoHandler
    {
        private readonly IProcessoService processoService;
        private readonly IDocumentoService documentoService;
        private readonly IInformacaoAdicionalService informacaoAdicionalService;
        private readonly IMapper mapper;

        public ProcessoHandler(IProcessoService processoService,
                                IDocumentoService documentoService,
                                IInformacaoAdicionalService informacaoAdicionalService,
                                IMapper mapper)
        {
            this.processoService = processoService;
            this.documentoService = documentoService;
            this.informacaoAdicionalService = informacaoAdicionalService;
            this.mapper = mapper;
        }

        public async Task<ProcessoModel> ProcessarSubsidios(string processo)
        {
            #region Buscar dados do processo
            var processoFornecedor = await processoService.ObterProcesso(processo);
            var retornoProcesso = mapper.Map<ProcessoModel>(processoFornecedor);
            retornoProcesso.Codigo = processo;
            retornoProcesso.NumeroProcesso = processo;
            retornoProcesso.ProcessoEletronico = "E" + processo;
            #endregion

            #region Buscar informações adicionais
            var informacoesAdicionaisFornecedor = await informacaoAdicionalService.ObterInformacoesAdicionais(processo);
            var retornoInformacoesAdicionais = mapper.Map<ProcessoModel>(informacoesAdicionaisFornecedor);
            retornoProcesso.InformacoesAdicionais = retornoInformacoesAdicionais.InformacoesAdicionais;
            #endregion

            #region Buscar documentos
            var documentosFornecedor = await documentoService.ObterDocumentos(processo);
            var retornoDocumentos = mapper.Map<ProcessoModel>(documentosFornecedor);
            retornoProcesso.Documentos = retornoDocumentos.Documentos;
            #endregion

            return retornoProcesso;
        }

    }

}
