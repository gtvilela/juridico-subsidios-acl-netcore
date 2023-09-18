using Juridico.Subsidios.Acl.Domain.Models;

namespace Juridico.Subsidios.Acl.Tests.Fakes
{
    public static class ProcessoFake
    {
        public static ProcessoModel ObterProcessoDefault()
        {
            #region Documentos Fake
            var cnh = DocumentoFake.ObterDocumentoCnhDefault();
            var bo = DocumentoFake.ObterDocumentoBoDefault();
            var crlv = DocumentoFake.ObterDocumentoCrlvDefault();
            var contrato = DocumentoFake.ObterDocumentoContratoDefault();
            #endregion

            #region Informações Adicionais Fake
            var codigoContrato = InformacaoAdicionalFake.ObterInformacaoAdicionalContratoDefault();
            var placa = InformacaoAdicionalFake.ObterInformacaoAdicionalPlacaDefault();
            var condutorAdicional = InformacaoAdicionalFake.ObterInformacaoAdicionalCondutorAdicionalDefault();
            var codigocliente = InformacaoAdicionalFake.ObterInformacaoAdicionalCodigoClienteDefault();
            #endregion

            return new ProcessoModel()
            {
               Comarca = "Belo Horizonte",
               Usuario = "123456",
               Codigo = "16099",
               Estado = "MG",
               MateriaLegal = "Cível",
               NumeroProcesso = "00062-2003-014-04-00-3",
               ProcessoEletronico = "00062-2003-014-04-00-3",
               Vara = "2ª Vara Civel",
               Documentos= new List<DocumentoModel>() { cnh, bo, crlv, contrato },
               InformacoesAdicionais = new List<InformacaoAdicionalModel>() { codigoContrato, placa, condutorAdicional, codigocliente }
            };
        }
    }
}
