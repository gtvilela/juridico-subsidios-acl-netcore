using Juridico.Subsidios.Acl.Domain.Extensions;
using Juridico.Subsidios.Acl.Domain.Interfaces;
using System.Text.Json;

namespace Juridico.Subsidios.Acl.Domain.Models.CheckModels
{
    /// <summary>
    /// Modelo de dados utilizado para a checagem de subsídios existentes no fornecedor
    /// </summary>
    public class DocumentosCheckModel
    {
        /// <summary>
        /// Referência do documento Contrato no fornecedor
        /// </summary>
        public bool Contrato { get; set; }
        /// <summary>
        /// Referência do documento Comprovante de Pagamento no fornecedor
        /// </summary>
        public bool ComprovantePagamento { get; set; }
        /// <summary>
        /// Referência do documento CRLV no fornecedor
        /// </summary>
        public bool Crlv { get; set; }
        /// <summary>
        /// Referência do documento CNH no fornecedor
        /// </summary>
        public bool Cnh { get; set; }
        /// <summary>
        /// Referência do documento B.O. no fornecedor
        /// </summary>
        public bool BoletimOcorrencia { get; set; }

        public DocumentosCheckModel(List<DocumentoModel> documentos,
                                   IConfigCatService configCatService)
        {
            var codigosDocumentos =  configCatService.BuscarCodigosDocumentos().Result;
            Contrato = DocumentoJaCadastrado(nameof(Contrato), codigosDocumentos, documentos);
            ComprovantePagamento = DocumentoJaCadastrado(nameof(ComprovantePagamento), codigosDocumentos, documentos);
            Crlv = DocumentoJaCadastrado(nameof(Crlv), codigosDocumentos, documentos);
            Cnh = DocumentoJaCadastrado(nameof(Cnh), codigosDocumentos, documentos);
            BoletimOcorrencia = DocumentoJaCadastrado(nameof(BoletimOcorrencia), codigosDocumentos, documentos);
        }

        private static bool DocumentoJaCadastrado(string documento,
                                                            JsonDocument jsonDocumentos,
                                                            List<DocumentoModel> documentos)
        {
            var codigoDocumento = jsonDocumentos.RootElement.GetProperty(documento.ToCamelCase()).ToString();
            return documentos.Any(x => x.CodigoTipo == Convert.ToInt32(codigoDocumento));
        }
    }
}