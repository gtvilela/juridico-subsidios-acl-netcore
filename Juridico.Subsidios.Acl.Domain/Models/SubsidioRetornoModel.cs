namespace Juridico.Subsidios.Acl.Domain.Models
{
    public class SubsidioRetornoModel
    {
        public string Contrato { get; set; }
        public string Placa { get; set; }
        public List<string> DocumentosMateriaLegal { get; set; }
        public ProcessoModel ProcessoFornecedor { get; set; }


        public SubsidioRetornoModel(string contrato, 
                                    string placa, 
                                    List<string> documentosMateriaLegal, 
                                    ProcessoModel processoFornecedor)
        {
            Contrato = contrato;
            Placa = placa;
            DocumentosMateriaLegal = documentosMateriaLegal;
            ProcessoFornecedor = processoFornecedor;
        }

        public SubsidioRetornoModel()
        {
        }
    }
}
