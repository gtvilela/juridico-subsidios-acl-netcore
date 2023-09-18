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
                Nome = "Contrato",
                Valor = "XXX123456",
                Descricao = "Código do contrato com o cliente",
                Usuario = "123456"
            };
        }

        public static InformacaoAdicionalModel ObterInformacaoAdicionalPlacaDefault()
        {
            return new InformacaoAdicionalModel()
            {
                Codigo = 2,
                Nome =  "Placa",
                Valor = "RI02A18",
                Descricao = "Código da placa do veículo alugado pelo cliente",
                Usuario = "123456"
            };
        }

        public static InformacaoAdicionalModel ObterInformacaoAdicionalCondutorAdicionalDefault()
        {
            return new InformacaoAdicionalModel()
            {
                Codigo = 3,
                Nome = "Condutor Adicional",
                Valor = "Sim",
                Descricao = "Se há um condutor adicional cadastrado no contrato com o cliente.",
                Usuario = "123456"
            };
        }

        public static InformacaoAdicionalModel ObterInformacaoAdicionalCodigoClienteDefault()
        {
            return new InformacaoAdicionalModel()
            {
                Codigo = 4,
                Nome = "Código do cliente",
                Valor = "987654",
                Descricao = "Código do cliente",
                Usuario = "123456"
            };
        }
    }
}
