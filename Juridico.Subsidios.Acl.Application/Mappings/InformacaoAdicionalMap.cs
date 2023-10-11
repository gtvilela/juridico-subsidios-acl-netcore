using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Domain.Mappings
{
    public class InformacaoAdicionalMap : Profile
    {
        public InformacaoAdicionalMap()
        {
            CreateMap<InformacaoAdicionalFornecedorModel, ProcessoModel>()
                .ForMember(dest => dest.InformacoesAdicionais, m => m.MapFrom(src => src.InformacoesAdicionais));

            CreateMap<InformacaoAdicionalProcessoIntegracao, InformacaoAdicionalModel>()
                .ForMember(dest => dest.Codigo, m => m.MapFrom(src => src.Codigo))
                .ForMember(dest => dest.CodigoProcesso, m => m.Ignore())
                .ForMember(dest => dest.Valor, m => m.MapFrom(src => src.InformacaoAdicional))
                .ForMember(dest => dest.Usuario, m => m.MapFrom(src => src.Usuario))
                .ForMember(dest => dest.Nome, m => m.MapFrom(src => src.Descricao));
        }
    }
}
