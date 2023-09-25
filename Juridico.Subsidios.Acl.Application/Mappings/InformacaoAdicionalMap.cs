using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Models;

namespace Juridico.Subsidios.Acl.Domain.Mappings
{
    public class InformacaoAdicionalMap : Profile
    {
        public InformacaoAdicionalMap()
        {
            CreateMap<InformacaoAdicionalProcessoIntegracao, InformacaoAdicionalModel>()
                .ForMember(dest => dest.Codigo, m => m.MapFrom(src => src.CodigoInforAdicionalProcesso))
                .ForMember(dest => dest.CodigoProcesso, m => m.MapFrom(src => src.CodigoProcesso))
                .ForMember(dest => dest.Valor, m => m.MapFrom(src => src.InformacaoAdicional))
                .ForMember(dest => dest.Usuario, m => m.MapFrom(src => src.Usuario))
                .ForMember(dest => dest.Nome, m => m.MapFrom(src => src.DescricaoTipoInfoAddProcesso));
        }
    }
}
