using Juridico.Subsidios.Acl.Domain.Models;

namespace Juridico.Subsidios.Acl.Tests.Fakes
{
    public static class InformacaoAdicionalFake
    {
        public static InformacaoAdicionalModel ObterInformacaoAdicionalContratoDefault()
        {
            return new InformacaoAdicionalModel()
            {
                Codigo = 1,
                Valor = "Contrato",
                Descricao = "Código do contrato com o cliente"
            };
        }

        public static InformacaoAdicionalModel ObterInformacaoAdicionalPlacaDefault()
        {
            return new InformacaoAdicionalModel()
            {
                Codigo = 2,
                Valor = "Placa",
                Descricao = "Código da placa do veículo alugado pelo cliente"
            };
        }

        public static InformacaoAdicionalModel ObterInformacaoAdicionalCondutorAdicionalDefault()
        {
            return new InformacaoAdicionalModel()
            {
                Codigo = 3,
                Valor = "Sim",
                Descricao = "Se há um condutor adicional cadastrado no contrato com o cliente."
            };
        }

        public static InformacaoAdicionalModel ObterInformacaoAdicionalCodigoClienteDefault()
        {
            return new InformacaoAdicionalModel()
            {
                Codigo = 4,
                Valor = "987654",
                Descricao = "Código do cliente"
            };
        }
    }
}
