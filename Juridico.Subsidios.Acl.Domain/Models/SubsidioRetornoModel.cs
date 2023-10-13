using Juridico.Subsidios.Acl.Domain.Models.CheckModels;

namespace Juridico.Subsidios.Acl.Domain.Models
{
    public class SubsidioRetornoModel
    {
        public string Contrato { get; set; }
        public string Placa { get; set; }
        public SubsidiosCheckModel SubsidiosCheckModel { get; set; }


        public SubsidioRetornoModel(string contrato, 
                                    string placa, 
                                    SubsidiosCheckModel subsidiosCheck)
        {
            Contrato = contrato;
            Placa = placa;
            SubsidiosCheckModel= subsidiosCheck;
        }

        public SubsidioRetornoModel()
        {
        }
    }
}
