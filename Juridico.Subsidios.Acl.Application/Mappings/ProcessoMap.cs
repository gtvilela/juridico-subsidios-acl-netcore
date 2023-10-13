using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Domain.Mappings
{
    public class ProcessoMap : Profile
    {
        public ProcessoMap()
        {
            CreateMap<ProcessoFornecedorRetornoModel, ProcessoModel>()
                .ForMember(dest => dest.Codigo, m => m.Ignore())
                .ForMember(dest => dest.NumeroProcesso, m => m.MapFrom(src => src.NumeroProcesso))
                .ForMember(dest => dest.Vara, m => m.MapFrom(src => src.Vara))
                .ForMember(dest => dest.Comarca, m => m.Ignore())
                .ForMember(dest => dest.ProcessoEletronico, m => m.MapFrom(src => src.ProcessoEletronico))
                .ForMember(dest => dest.Estado, m => m.MapFrom(src => src.SiglaUf))
                .ConstructUsing(src =>
                    new ProcessoModel(
                        src.Codigo)
                    ); 
        }
    }
}
