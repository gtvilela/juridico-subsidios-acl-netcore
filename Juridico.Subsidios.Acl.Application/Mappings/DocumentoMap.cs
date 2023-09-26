using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Domain.Mappings
{
    public class DocumentoMap : Profile
    {
        public DocumentoMap()
        {
            CreateMap<DocumentoProcessoIntegracao, DocumentoModel>()
                .ForMember(dest => dest.CodigoProcesso, m => m.Ignore())
                .ForMember(dest => dest.DataInclusao, m => m.MapFrom(src => src.DataDocumento))
                .ForMember(dest => dest.Nome, m => m.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Descricao, m => m.MapFrom(src => src.Descricao))
                .ForMember(dest => dest.Usuario, m => m.MapFrom(src => src.Usuario))
                .ForMember(dest => dest.Base64, m => m.MapFrom(src => src.Arquivo));
        }
    }
}
