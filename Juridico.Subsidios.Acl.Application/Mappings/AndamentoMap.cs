using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.EnvioFornecedor;

namespace Juridico.Subsidios.Acl.Domain.Mappings
{
    public class AndamentoMap : Profile
    {
        public AndamentoMap()
        {
            CreateMap<AndamentoModel, AndamentoFornecedorEnvioModel>();
        }
    }
}
